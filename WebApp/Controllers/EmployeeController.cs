using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

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
            return View();
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
        public IActionResult WorkSchedule()
        {

            if (IsMobile()) return RedirectToAction("WorkSchedule", "Mobile");
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