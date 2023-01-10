using Bumbo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    public class EmployeeController : Controller
    {
        private BumboDbContext db;
        private UserManager<Account> userManager;

        public EmployeeController(BumboDbContext dbContext, UserManager<Account> user) { db = dbContext; userManager = user; }

        private bool IsMobile() {
            var userAgent = Request.Headers["User-Agent"].ToString().ToLower();

            if(userAgent == null) return false;

            return userAgent.Contains("blackberry")
                || userAgent.Contains("webos")
                || userAgent.Contains("iphone")
                || userAgent.Contains("iemobile")
                || userAgent.Contains("android")
                || userAgent.Contains("windows phone")
                || userAgent.Contains("ipad")
                || userAgent.Contains("ipod")
                || Request.Cookies.ContainsKey("ForceMobile");
        }

        private DateTime ParseDate(int year, int month, int day, DateTime defaultDate)
        {
            try
            {
                return new DateTime(year, month, day);
            }
            catch(Exception)
            {
                return defaultDate;
            }
        }

        public IActionResult EnableMobile()
        {
            Response.Cookies.Append("ForceMobile", "yes");
            return RedirectToAction("WorkSchedule");
        }

        public IActionResult DisableMobile()
        {
            if(Request.Cookies.ContainsKey("ForceMobile"))
                Response.Cookies.Delete("ForceMobile");

            return RedirectToAction("WorkSchedule");
        }

        private IActionResult LoadPage<MobileModelType, DesktopModelType>(MobileModelType mobileModel, DesktopModelType desktopModel, [CallerMemberName] string caller = "")
        {
            if(IsMobile())
            {
                ViewBag.IsMobile = true;
                return View(caller + "Mobile", mobileModel);
            }
            else return View(caller + "Desktop", desktopModel);
        }

        private IActionResult LoadPage<ModelType>(ModelType model, [CallerMemberName] string caller = "")
        {
            return LoadPage(model, model, caller);
        }

        private IActionResult LoadPage([CallerMemberName] string caller = "")
        {
            if(IsMobile())
            {
                ViewBag.IsMobile = true;
                return View(caller + "Mobile");
            }
            else return View(caller + "Desktop");
        }

        [Authorize(Roles = "Employee")]
        public IActionResult WorkSchedule(int year, int month, int day, bool fullSize)
        {
            DateTime date = ParseDate(year, month, day, DateTime.Today);

            date = ManagerController.GetStartOfWeek(date);

            ViewBag.Date = date;

            ViewBag.StartDate = date;
            ViewBag.StartDutchDate = ManagerController.GetDutchDate(date);

            ViewBag.EndDate = date.AddDays(6);
            ViewBag.EndDutchDate = ManagerController.GetDutchDate(date.AddDays(6));

            ViewBag.FullSize = fullSize;

            return LoadPage((
                from Schedule in db.Schedules
                join Employee in db.Employees
                on Schedule.EmployeeId equals Employee.Id
                where Employee.UserName == userManager.GetUserName(User) && Schedule.StartTime.Date >= date && Schedule.EndTime.Date < date.AddDays(7)
                select Schedule
            ).ToList().OrderBy(schedule => schedule.StartTime));
        }

        [Authorize(Roles = "Employee")]
        public IActionResult Availability() {
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

            return LoadPage(availabilities, form);
        }

        [HttpPost]
        [Authorize(Roles = "Employee")]
        public IActionResult DesktopAvailability(WeeklyAvailabilityForm form) 
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
        public IActionResult EditAvailability(Weekday weekday) {
            AvailabilityForm form = new AvailabilityForm();
            form.Weekday = weekday;

            var availability = (from Availability in db.Availabilities
                                join Employee in db.Employees
                on Availability.EmployeeId equals Employee.Id
                                where Employee.UserName == userManager.GetUserName(User)
                && Availability.StartDate <= DateTime.Today
                && (Availability.EndDate == null || Availability.EndDate > DateTime.Today)
                && Availability.Weekday == weekday
                                select Availability
            ).ToList();

            form.HasAvailability1 = availability.Count > 0;
            form.HasAvailability2 = availability.Count == 2;

            if(form.HasAvailability1) form.Availability1 = availability[0];
            if(form.HasAvailability2) form.Availability2 = availability[1];

            ViewBag.CanCreateInstantly = !(from Availability in db.Availabilities
                                           join Employee in db.Employees
                                           on Availability.EmployeeId equals Employee.Id
                                           where Employee.UserName == userManager.GetUserName(User)
                                           && Availability.Weekday == weekday
                                           select Availability
            ).Any();

            return LoadPage(form);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
        public IActionResult EditAvailability(AvailabilityForm form) {
            if(form.HasAvailability1 && form.Availability1.EndTime < form.Availability1.StartTime)
                (form.Availability1.EndTime, form.Availability1.StartTime) = (form.Availability1.StartTime, form.Availability1.EndTime);

            if(form.HasAvailability2 && form.Availability2.EndTime < form.Availability2.StartTime)
                (form.Availability2.EndTime, form.Availability2.StartTime) = (form.Availability2.StartTime, form.Availability2.EndTime);

            var oldAvailability = (from Availability in db.Availabilities
                                   join Employee in db.Employees
                on Availability.EmployeeId equals Employee.Id
                                   where Employee.UserName == userManager.GetUserName(User)
                && Availability.StartDate <= DateTime.Today
                && (Availability.EndDate == null || Availability.EndDate > DateTime.Today)
                && Availability.Weekday == form.Weekday
                                   select Availability
            ).ToList();

            bool canCreateInstantly = !(from Availability in db.Availabilities
                                        join Employee in db.Employees
                on Availability.EmployeeId equals Employee.Id
                                        where Employee.UserName == userManager.GetUserName(User)
                && Availability.Weekday == form.Weekday
                                        select Availability
            ).Any();

            if(form.HasAvailability1) {
                form.Availability1.Weekday = form.Weekday;

                if(canCreateInstantly) form.Availability1.StartDate = DateTime.Today;
                else form.Availability1.StartDate = DateTime.Today.AddDays(21);

                form.Availability1.EmployeeId = (from Employee in db.Employees where Employee.UserName == userManager.GetUserName(User) select Employee.Id).First();

                // Round up start time and round down end time
                if(form.Availability1.StartTime.Minute != 0)
                    form.Availability1.StartTime = form.Availability1.StartTime.AddHours(1).AddMinutes(-form.Availability1.StartTime.Minute);

                if(form.Availability1.EndTime.Minute != 0)
                    form.Availability1.EndTime = form.Availability1.EndTime.AddMinutes(-form.Availability1.EndTime.Minute);

                db.Availabilities.Add(form.Availability1);
            }

            if(form.HasAvailability2) {
                form.Availability2.Weekday = form.Weekday;

                if(canCreateInstantly) form.Availability2.StartDate = DateTime.Today;
                else form.Availability2.StartDate = DateTime.Today.AddDays(21);

                form.Availability2.EmployeeId = (from Employee in db.Employees where Employee.UserName == userManager.GetUserName(User) select Employee.Id).First();

                // Round up start time and round down end time
                if(form.Availability2.StartTime.Minute != 0)
                    form.Availability2.StartTime = form.Availability2.StartTime.AddHours(1).AddMinutes(-form.Availability2.StartTime.Minute);

                if(form.Availability2.EndTime.Minute != 0)
                    form.Availability2.EndTime = form.Availability2.EndTime.AddMinutes(-form.Availability2.EndTime.Minute);

                db.Availabilities.Add(form.Availability2);
            }

            if(oldAvailability.Count > 0) oldAvailability[0].EndDate = DateTime.Today.AddDays(21);
            if(oldAvailability.Count > 1) oldAvailability[1].EndDate = DateTime.Today.AddDays(21);

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

            return RedirectToAction("LeaveRequests");
        }

        [Authorize(Roles = "Employee")]
        public IActionResult LeaveRequests()
        {
            ViewBag.Requests = (
                from LeaveRequest in db.LeaveRequests
                join Employee in db.Employees
                on LeaveRequest.EmployeeId equals Employee.Id
                where Employee.UserName == userManager.GetUserName(User)
                && LeaveRequest.EndDate >= DateTime.Today
                select LeaveRequest
            ).ToList();

            return LoadPage();
        }

        [Authorize(Roles = "Employee")]
        public IActionResult RequestLeave() {
            return LoadPage();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
        public IActionResult RequestLeave(LeaveRequest request) {
            if(ModelState.IsValid) {
                if(request.EndDate < request.StartDate) (request.StartDate, request.EndDate) = (request.EndDate, request.StartDate);

                request.EmployeeId = (from Employee in db.Employees where Employee.UserName == userManager.GetUserName(User) select Employee.Id).First();

                db.LeaveRequests.Add(request);
                db.SaveChanges();

                return RedirectToAction("LeaveRequests");
            }

            return LoadPage(request);
        }

        [Authorize(Roles = "Employee")]
        public IActionResult SchoolSchedule(string? alertMessage) {

            ViewBag.AlertMessage = alertMessage;  

            return LoadPage((
                from SchoolSchedule in db.SchoolSchedules
                join Employee in db.Employees
                on SchoolSchedule.EmployeeId equals Employee.Id
                where Employee.UserName == userManager.GetUserName(User) && SchoolSchedule.StartDate <= DateTime.Today && (SchoolSchedule.EndDate == null || SchoolSchedule.EndDate > DateTime.Today)
                select SchoolSchedule
            ).ToList().OrderBy(schedule => schedule.StartTime));
        }

        [Authorize(Roles = "Employee")]
        public IActionResult EditSchoolSchedule(Weekday weekday) {
            ViewBag.CanCreateInstantly = !(from SchoolSchedule in db.SchoolSchedules
                                           join Employee in db.Employees
                                           on SchoolSchedule.EmployeeId equals Employee.Id
                                           where Employee.UserName == userManager.GetUserName(User)
                                           && SchoolSchedule.Weekday == weekday
                                           select SchoolSchedule
            ).Any();

            ViewBag.Weekday = weekday;

            return LoadPage((from SchoolSchedule in db.SchoolSchedules
                   join Employee in db.Employees
                   on SchoolSchedule.EmployeeId equals Employee.Id
                   where Employee.UserName == userManager.GetUserName(User)
                   && SchoolSchedule.StartDate <= DateTime.Today
                   && (SchoolSchedule.EndDate == null || SchoolSchedule.EndDate > DateTime.Today)
                   && SchoolSchedule.Weekday == weekday
                   select SchoolSchedule
          ).FirstOrDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
        public IActionResult EditSchoolSchedule(SchoolSchedule schedule) {
            if(schedule.EndTime < schedule.StartTime)
                (schedule.EndTime, schedule.StartTime) = (schedule.StartTime, schedule.EndTime);

            if (schedule.EndTime == schedule.StartTime)
                return RedirectToAction("SchoolSchedule", new { alertMessage = "Tijden mogen niet hetzelfde zijn" });

            var oldSchedule = (from SchoolSchedule in db.SchoolSchedules
                               join Employee in db.Employees
                on SchoolSchedule.EmployeeId equals Employee.Id
                               where Employee.UserName == userManager.GetUserName(User)
                && SchoolSchedule.StartDate <= DateTime.Today
                && (SchoolSchedule.EndDate == null || SchoolSchedule.EndDate > DateTime.Today)
                && SchoolSchedule.Weekday == schedule.Weekday
                               select SchoolSchedule
            ).ToList();

            bool canCreateInstantly = !(from SchoolSchedule in db.SchoolSchedules
                                        join Employee in db.Employees
                on SchoolSchedule.EmployeeId equals Employee.Id
                                        where Employee.UserName == userManager.GetUserName(User)
                && SchoolSchedule.Weekday == schedule.Weekday
                                        select SchoolSchedule
            ).Any();

            if(canCreateInstantly) schedule.StartDate = DateTime.Today;
            else schedule.StartDate = DateTime.Today.AddDays(21);

            schedule.EmployeeId = (from Employee in db.Employees where Employee.UserName == userManager.GetUserName(User) select Employee.Id).First();

            // Round down start time and round up end time
            if(schedule.StartTime.Minute != 0)
                schedule.StartTime = schedule.StartTime.AddMinutes(-schedule.StartTime.Minute);

            if(schedule.EndTime.Minute != 0)
                schedule.EndTime = schedule.EndTime.AddHours(1).AddMinutes(-schedule.EndTime.Minute);

            db.SchoolSchedules.Add(schedule);

            if(oldSchedule.Count > 0) oldSchedule[0].EndDate = DateTime.Today.AddDays(21);

            db.SaveChanges();
            return RedirectToAction("SchoolSchedule");
        }

        [Authorize(Roles = "Employee")]
        public IActionResult Index()
        {
            return RedirectToAction("WorkSchedule");
        }
    }
}
