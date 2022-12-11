using Bumbo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApp.Domain;
using Microsoft.AspNetCore.Identity;
using System.Web;
using Azure.Core;

namespace Bumbo.Controllers
{
    public class MobileController : Controller
    {
        private BumboDbContext db;
        private UserManager<Account> userManager;
        public MobileController(UserManager<Account> user, BumboDbContext dbContext)
        {
            userManager = user;
            db = dbContext;
        }

        [Authorize(Roles = "Employee")]
        public IActionResult Availability()
        {
            ViewBag.IsMobile = true;

            return View((
                from Availability in db.Availabilities
                join Employee in db.Employees
                on Availability.EmployeeId equals Employee.Id
                where Employee.UserName == userManager.GetUserName(User) 
                && Availability.StartDate <= DateTime.Today 
                && (Availability.EndDate == null || Availability.EndDate > DateTime.Today)
                select Availability
            ).ToList());
        }

        [Authorize(Roles = "Employee")]
        public IActionResult EditAvailability(Weekday weekday)
        {
            ViewBag.IsMobile = true;

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

            return View(form);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
        public IActionResult EditAvailability(AvailabilityForm form)
        {
            ViewBag.IsMobile = true;

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

            if(form.HasAvailability1)
            {
                form.Availability1.StartDate = DateTime.Today.AddDays(21);
                form.Availability1.EmployeeId = (from Employee in db.Employees where Employee.UserName == userManager.GetUserName(User) select Employee.Id).First();

                db.Availabilities.Add(form.Availability1);
            }

            if(form.HasAvailability2)
            {
                form.Availability2.StartDate = DateTime.Today.AddDays(21);
                form.Availability2.EmployeeId = (from Employee in db.Employees where Employee.UserName == userManager.GetUserName(User) select Employee.Id).First();

                db.Availabilities.Add(form.Availability2);
            }

            if(oldAvailability.Count > 0) oldAvailability[0].EndDate = DateTime.Today.AddDays(21);
            if(oldAvailability.Count > 1) oldAvailability[1].EndDate = DateTime.Today.AddDays(21);

            db.SaveChanges();
            return RedirectToAction("Availability");
        }

        [Authorize(Roles = "Employee")]
        public IActionResult LeaveRequests()
        {
            ViewBag.IsMobile = true;
            return View((
            from LeaveRequest in db.LeaveRequests
            join Employee in db.Employees
                on LeaveRequest.EmployeeId equals Employee.Id
                where Employee.UserName == userManager.GetUserName(User)
                select LeaveRequest
            ).ToList());
        }

        [Authorize(Roles = "Employee")]
        public IActionResult RequestLeave()
        {
            ViewBag.IsMobile = true;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
        public IActionResult RequestLeave(LeaveRequest request)
        {
            ViewBag.IsMobile = true;

            if(ModelState.IsValid)
            {
                if(request.EndDate < request.StartDate) (request.StartDate, request.EndDate) = (request.EndDate, request.StartDate);

                request.EmployeeId = (from Employee in db.Employees where Employee.UserName == userManager.GetUserName(User) select Employee.Id).First();

                db.LeaveRequests.Add(request);
                db.SaveChanges();

                return RedirectToAction("LeaveRequests");
            }

            return View(request);
        }

        [Authorize(Roles = "Employee")]
        public IActionResult EditSchoolSchedule()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        [Authorize(Roles = "Employee")]
        public IActionResult WorkSchedule(int year, int month, int day, bool fullSize)
        {
            ViewBag.IsMobile = true;

            DateTime date;

            try
            {
                date = new DateTime(year, month, day);
            }
            catch(Exception ex)
            {
                date = DateTime.Today;
            }

            date = date.AddDays(1 - (int)date.DayOfWeek);

            ViewBag.Date = date;
            ViewBag.FullSize = fullSize;

            return View((
                from Schedule in db.Schedules
                join Employee in db.Employees
                on Schedule.EmployeeId equals Employee.Id
                where Employee.UserName == userManager.GetUserName(User) && Schedule.StartTime.Date >= date && Schedule.EndTime.Date < date.AddDays(7)
                select Schedule
            ).ToList().OrderBy(schedule => schedule.StartTime));
        }

        [Authorize(Roles = "Employee")]
        public IActionResult InlineCalendar(
            int month, int year,
            int todayDay, int todayMonth, int todayYear,
            int selectedDay, int selectedMonth, int selectedYear,
            bool fullSize, string link
        )
        {
            int weekday = 1;
            switch(new DateOnly(year, month, 1).DayOfWeek)
            {
                case DayOfWeek.Monday: weekday = 1; break;
                case DayOfWeek.Tuesday: weekday = 2; break;
                case DayOfWeek.Wednesday: weekday = 3; break;
                case DayOfWeek.Thursday: weekday = 4; break;
                case DayOfWeek.Friday: weekday = 5; break;
                case DayOfWeek.Saturday: weekday = 6; break;
                case DayOfWeek.Sunday: weekday = 7; break;
            }

            CalendarData data = new CalendarData
            {
                CurrentMonth = month,
                CurrentYear = year,
                FirstWeekdayOfMonth = weekday,
                Today = new DateOnly(todayYear, todayMonth, todayDay),
                Selected = new DateOnly(selectedYear, selectedMonth, selectedDay)
            };

            ViewBag.FullSize = fullSize;

            data.Link = HttpUtility.UrlDecode(link);

            return PartialView(data);
        }

        [Authorize(Roles = "Employee")]
        public IActionResult Index()
        {
            return RedirectToAction("WorkSchedule");
        }
    }
}