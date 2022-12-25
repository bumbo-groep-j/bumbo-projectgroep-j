using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Bumbo.Models;
using Microsoft.VisualBasic;

namespace Bumbo.Controllers
{
    public class EmployeeController : Controller
    {
        private BumboDbContext db;
        private UserManager<Account> userManager;

        public EmployeeController(BumboDbContext dbContext, UserManager<Account> user) { db = dbContext; userManager = user; }

        private bool IsMobile()
        {
            var userAgent = Request.Headers["User-Agent"].ToString().ToLower();

            if (userAgent == null) return false;

            return userAgent.Contains("blackberry")
                || userAgent.Contains("webos")
                || userAgent.Contains("iphone")
                || userAgent.Contains("iemobile")
                || userAgent.Contains("android")
                || userAgent.Contains("windows phone")
                || userAgent.Contains("ipad")
                || userAgent.Contains("ipod");
        }

        [Authorize(Roles = "Employee")]
        public IActionResult Availability()
        {
            if (IsMobile()) return RedirectToAction("Availability", "Mobile");

            WeeklyAvailabilityForm form = new WeeklyAvailabilityForm();

            form.Availability = new List<Availability>();
            form.HasAvailability = new List<bool>();
            form.CanCreateInstantly = new List<bool>();

            var availabilities = (from Availability in db.Availabilities
                join Employee in db.Employees
                on Availability.EmployeeId equals Employee.Id
                where Employee.UserName == userManager.GetUserName(User) 
                && Availability.StartDate <= DateTime.Today 
                && (Availability.EndDate == null || Availability.EndDate > DateTime.Today)
                select Availability
            ).ToList();

            for(int i = 0; i < 14; i++)
            {
                form.HasAvailability.Add(availabilities.Count(availability => availability.Weekday == (Weekday)(i % 7)) > i / 7);

                if(form.HasAvailability[i])
                    form.Availability.Add(availabilities.Where(availability => availability.Weekday == (Weekday)(i % 7)).ToList()[i / 7]);
                else
                    form.Availability.Add(new Availability());
            }

            for(int i = 0; i < 7; i++) 
                form.CanCreateInstantly.Add(!(from Availability in db.Availabilities
                    join Employee in db.Employees
                    on Availability.EmployeeId equals Employee.Id
                    where Employee.UserName == userManager.GetUserName(User) 
                    && Availability.Weekday == (Weekday)i
                    select Availability
                ).Any());

            return View(form);
        }

        [HttpPost]
        [Authorize(Roles = "Employee")]
        public IActionResult Availability(WeeklyAvailabilityForm form) 
        {
            List<Availability>[] oldAvailability = new List<Availability>[7];
            bool[] canCreateInstantly = new bool[7];

            for(int i = 0; i < 7; i++)
            {
                oldAvailability[i] = (from Availability in db.Availabilities
                    join Employee in db.Employees
                    on Availability.EmployeeId equals Employee.Id
                    where Employee.UserName == userManager.GetUserName(User) 
                    && Availability.StartDate <= DateTime.Today 
                    && (Availability.EndDate == null || Availability.EndDate > DateTime.Today)
                    && Availability.Weekday == (Weekday)i
                    select Availability
                ).ToList();

                canCreateInstantly[i] = !(from Availability in db.Availabilities
                    join Employee in db.Employees
                    on Availability.EmployeeId equals Employee.Id
                    where Employee.UserName == userManager.GetUserName(User) 
                    && Availability.Weekday == (Weekday)i
                    select Availability
                ).Any();
            }

            for(int i = 0; i < 14; i++)
            {
                if(form.HasAvailability[i])
                {
                    if(form.Availability[i].EndTime < form.Availability[i].StartTime)
                        (form.Availability[i].EndTime, form.Availability[i].StartTime) = (form.Availability[i].StartTime, form.Availability[i].EndTime);

                    if(canCreateInstantly[i % 7]) form.Availability[i].StartDate = DateTime.Today;
                    else form.Availability[i].StartDate = DateTime.Today.AddDays(21);

                    form.Availability[i].EmployeeId = (from Employee in db.Employees where Employee.UserName == userManager.GetUserName(User) select Employee.Id).First();

                    // Round up start time and round down end time
                    if(form.Availability[i].StartTime.Minute != 0)
                        form.Availability[i].StartTime = form.Availability[i].StartTime.AddHours(1).AddMinutes(-form.Availability[i].StartTime.Minute);

                    if(form.Availability[i].EndTime.Minute != 0)
                        form.Availability[i].EndTime = form.Availability[i].EndTime.AddMinutes(-form.Availability[i].EndTime.Minute);

                    db.Availabilities.Add(form.Availability[i]);
                }

                if(oldAvailability[i % 7].Count > i / 7) oldAvailability[i % 7][i / 7].EndDate = DateTime.Today.AddDays(21);
            }

            db.SaveChanges();
            return RedirectToAction("Availability");
        }

        [Authorize(Roles = "Employee")]
        public IActionResult DeleteRequest(int id)
        {
            var request = db.LeaveRequests.FirstOrDefault(r => r.Id == id);
            if (request != null)
            {
                db.LeaveRequests.Remove(request);
                db.SaveChanges();
            }

            return RedirectToAction("RequestLeave");
        }

        [Authorize(Roles = "Employee")]
        public IActionResult RequestLeave()
        {
            if(IsMobile()) return RedirectToAction("RequestLeave", "Mobile");

            ViewBag.Requests = (
                from LeaveRequest in db.LeaveRequests
                join Employee in db.Employees
                on LeaveRequest.EmployeeId equals Employee.Id
                where Employee.UserName == userManager.GetUserName(User)
                select LeaveRequest
            ).ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
        public IActionResult RequestLeave(LeaveRequest request)
        {
            if (ModelState.IsValid)
            {
                if(request.EndDate < request.StartDate) (request.StartDate, request.EndDate) = (request.EndDate, request.StartDate);

                request.InsertDate = DateTime.Now;
                request.EmployeeId = (from Employee in db.Employees where Employee.UserName == userManager.GetUserName(User) select Employee.Id).First();

                db.LeaveRequests.Add(request);
                db.SaveChanges();

                return RedirectToAction("RequestLeave");
            }

            return View(request);
        }

        [Authorize(Roles = "Employee")]
        public IActionResult SchoolSchedule(string UserName)
        {

            if (IsMobile()) return RedirectToAction("SchoolSchedule", "Mobile");

            var employeeId = db.Employees.Where(x => x.UserName == UserName).Select(x => x.Id).FirstOrDefault();
            List<SchoolSchedule> schoolSchedules = db.SchoolSchedules.Where(x => (x.EmployeeId == employeeId)).ToList();

            List<Weekday> weekdays = Enum.GetValues(typeof(Weekday)).Cast<Weekday>().Take(5).ToList();
            ViewBag.Days = weekdays;

            ViewBag.Schedule = (schoolSchedules.Count == 0) ? null : schoolSchedules;
            ViewBag.EmployeeId = employeeId;
            return View();
        }



        [Authorize(Roles = "Employee")]
        public IActionResult DeleteSingleSchoolSchedule(int schoolScheduleId, int employeeId)
        {
            var userName = db.Employees.Where(x => x.Id == employeeId).Select(y => y.UserName).FirstOrDefault();
            try
            {
                var schedule = db.SchoolSchedules.Where(x => x.Id == schoolScheduleId).FirstOrDefault();
                db.SchoolSchedules.Remove(schedule);
                db.SaveChanges();
            }
            catch (Exception e)
            {

            }
            return RedirectToAction("SchoolSchedule", new { UserName = userName });
        }

        [Authorize(Roles = "Employee")]
        public IActionResult DeleteAllSchoolSchedule(int employeeId)
        {
            var userName = db.Employees.Where(x => x.Id == employeeId).Select(y => y.UserName).FirstOrDefault();

            foreach (var schedule in db.SchoolSchedules.Where(x => x.EmployeeId == employeeId))
            {
                db.SchoolSchedules.Remove(schedule);
                db.SaveChanges();
            }

            return RedirectToAction("SchoolSchedule", new { UserName = userName });
        }

        [HttpGet]
        public IActionResult EditSchoolSchedule(string day, Weekday weekDay, int? schoolScheduleId, int? employeeId)
        {
            try
            {
                if (schoolScheduleId != null)
                {
                    var schedule = db.SchoolSchedules.Where(x => x.Id == schoolScheduleId).FirstOrDefault();
                    ViewBag.ScheduleId = schedule.Id;
                    ViewBag.StartTime = schedule.StartTime.ToString("HH:mm");
                    ViewBag.EndTime = schedule.EndTime.ToString("HH:mm");
                }

            }
            catch (Exception e)
            {

            }
            ViewBag.EmployeeId = employeeId;
            ViewBag.WeekDay = weekDay;
            ViewBag.Day = day;
            return PartialView("EditSchoolSchedule");
        }

        [Authorize(Roles = "Employee")]
        [HttpPost]
        public IActionResult EditSchoolSchedule(SchoolSchedule schedule)
        {
            var userName = db.Employees.Where(x => x.Id == schedule.EmployeeId).Select(y => y.UserName).FirstOrDefault();
            try
            {
                if (schedule.EndTime < schedule.StartTime)
                    (schedule.EndTime, schedule.StartTime) = (schedule.StartTime, schedule.EndTime);

                bool canCreateInStantly = !db.SchoolSchedules.Where(x => x.EmployeeId == schedule.EmployeeId
                                                            && x.Weekday == schedule.Weekday).Any();

                if (canCreateInStantly) schedule.StartDate = DateTime.Today;
                else schedule.EndDate = DateTime.Today.AddDays(21);

                db.SchoolSchedules.Update(schedule);

                db.SaveChanges();

            }
            catch (Exception e)
            {
            }
            return RedirectToAction("SchoolSchedule", new { UserName = userName });
        }


        [Authorize(Roles = "Employee")]
        public IActionResult WorkSchedule(string userName, DateTime date)
        {
            if (IsMobile()) return RedirectToAction("WorkSchedule", "Mobile");
            
            var employeeId = db.Employees.Where(x => x.UserName == userName).Select(y => y.Id).FirstOrDefault();
            var schedules = db.Schedules.Where(x => x.EmployeeId == employeeId).ToList();

            ViewBag.Schedules = schedules;

            DateTime today = DateTime.Today;
            int currentDayOfWeek = (int)today.DayOfWeek;
            DateTime lastweek = today.AddDays(-currentDayOfWeek);
            DateTime monday = lastweek.AddDays(1);
            DateTime sunday = lastweek.AddDays(7);

            if (currentDayOfWeek == 0)
            {
                sunday = lastweek.AddDays(0);
                monday = monday.AddDays(-7);
            }
            var dates = Enumerable.Range(0, 7).Select(days => monday.AddDays(days)).ToList();

            ViewBag.Dates = dates;
            ViewBag.Monday = monday;
            ViewBag.Sunday = sunday;
            ViewBag.userName = userName;

            List<Weekday> weekdays = Enum.GetValues(typeof(Weekday)).Cast<Weekday>().ToList();
            ViewBag.Days = weekdays;

            return View();
        }

        [Authorize(Roles = "Employee")]
        public IActionResult Index()
        {
            return RedirectToAction("WorkSchedule");
        }
    }
}