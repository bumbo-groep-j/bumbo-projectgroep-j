using Bumbo.Models;
using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult LeaveRequests()
        {
            return View();
        }

        public void GetDate(DateTime date)
        {
            //Get the current day
            var dt = date;
            //Get first and last day of the week
            int begin = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
            int end = (7 + (DayOfWeek.Sunday - dt.DayOfWeek)) % 7;

            DateTime monday = dt.AddDays(-1 * begin).Date;
            DateTime sunday = dt.AddDays(end).Date;

            ViewBag.CurrentDate = dt;
            ViewBag.StartDate = monday;
            ViewBag.EndDate = sunday;
        }

       
        public IActionResult SetNewDate(DateTime oldDate, string previousOrNext)
        {
            DateTime CurrentDate = new DateTime();
            if (previousOrNext == "Next")
            {
                CurrentDate = oldDate.AddDays(+(int)oldDate.DayOfWeek + 6);
            }
            else if(previousOrNext == "Previous")
            {
                CurrentDate = oldDate.AddDays(-(int)oldDate.DayOfWeek - 6);
            }
        
            return RedirectToAction("Prognosis", new { date = CurrentDate });
        }

        public void GetDaysOftheWeek(DateTime currentWeek)
        {
            List<DateTime> listOfDays = new List<DateTime>();
            List<Prognosis> listOfData = new List<Prognosis>();

            var now = currentWeek;
            var currentDay = now.DayOfWeek;
            int days = (int)currentDay;
            DateTime sunday = new DateTime();

            if (days == 0)
            {
                days = 7;
                sunday = now.AddDays(-days);
            }
            else
            {
                sunday = now.AddDays(-days);
            }
            
            listOfDays = Enumerable.Range(1, 7)
                           .Select(d => sunday.AddDays(d))
                           .ToList();

            using (var ctx = new BumboDbContext())
            {
                var prognoses = ctx.Prognosis;

                foreach (var data in prognoses)
                {
                    DateTime dbDate = data.Date;
                    foreach (DateTime date in listOfDays)
                    {
                        if (dbDate.Date == date.Date)
                        {
                            listOfData.Add(data);
                        }
                    }
                }
            }

            ViewBag.Data = listOfData;
            ViewBag.Days = listOfDays;
        }

        public IActionResult Prognosis(DateTime? date)
        {
            DateTime dateTime = new DateTime();
            dateTime =  (!date.HasValue) ? DateTime.Now : date.Value;
            GetDate(dateTime);
            GetDaysOftheWeek(dateTime);
            return View();
        }

        [HttpPost]
        public ActionResult Prognosis(string totalColli, string totalCustomers)
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
