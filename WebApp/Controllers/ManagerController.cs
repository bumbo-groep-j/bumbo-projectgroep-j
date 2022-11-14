using Bumbo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult LeaveRequests()
        {
            return View();
        }

        public IActionResult Prognosis()
        {
            return View();
        }

        public IActionResult Scheduling()
        {
            return View();
        }

        public IActionResult WorkedHours()
        {
            return View();
        }

        public IActionResult Calendar(
            int month, int year,
            int todayDay, int todayMonth, int todayYear,
            int selectedDay, int selectedMonth, int selectedYear,
            int minimumDay, int minimumMonth, int minimumYear,
            int maximumDay, int maximumMonth, int maximumYear
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

            if(minimumDay != 0) data.MinimumDay = new DateOnly(minimumYear, minimumMonth, minimumDay);
            if(maximumDay != 0) data.MaximumDay = new DateOnly(maximumYear, maximumMonth, maximumDay);

            return PartialView(data);
        }
    }
}
