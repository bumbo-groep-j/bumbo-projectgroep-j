using Bumbo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class MobileController : Controller
    {
        public IActionResult Availability()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult EditAvailability()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult LeaveRequests()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult RequestLeave()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult SchoolSchedule()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult EditSchoolSchedule()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult WorkSchedule()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult InlineCalendar(
            int month, int year,
            int todayDay, int todayMonth, int todayYear,
            int selectedDay, int selectedMonth, int selectedYear,
            bool fullSize
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

            return PartialView(data);
        }

        public IActionResult Index()
        {
            return RedirectToAction("WorkSchedule");
        }
    }
}