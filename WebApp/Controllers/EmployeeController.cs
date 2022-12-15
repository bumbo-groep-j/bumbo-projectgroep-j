using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Bumbo.Models;

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
        public IActionResult SchoolSchedule()
        {
            if (IsMobile()) return RedirectToAction("SchoolSchedule", "Mobile");
            ViewData["Days"] = listDays();
            return View();
        }

        [Authorize(Roles = "Employee")]
        public List<string> listDays()
        {
            List<string> listOfDays = new List<string>();
            listOfDays.Add("Maandag");
            listOfDays.Add("Dinsdag");
            listOfDays.Add("Woensdag");
            listOfDays.Add("Donderdag");
            listOfDays.Add("Vrijdag");
            listOfDays.Add("Zaterdag");
            listOfDays.Add("Zondag");

            return listOfDays;
        }

        [Authorize(Roles = "Employee")]
        public IActionResult WorkSchedule()
        {

            //Get the current day
            /*var dt = DateTime.Now;
            //Get first and last day of the week
            int begin = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
            int end = (7 + (DayOfWeek.Sunday - dt.DayOfWeek)) % 7;
            
            DateTime beginTime = dt.AddDays(-1 * begin).Date;
            DateTime endTime = dt.AddDays(end).Date;
            ViewBag.StartDate = beginTime;
            ViewBag.EndDate = endTime;
            ViewBag.EndDate = endTime;*/
            if (IsMobile()) return RedirectToAction("WorkSchedule", "Mobile");
            ViewData["Days"] = listDays();

            return View();
        }

        [Authorize(Roles = "Employee")]
        public IActionResult Index()
        {
            return RedirectToAction("WorkSchedule");
        }
    }
}