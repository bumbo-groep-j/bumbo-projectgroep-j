using Bumbo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Web;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    public class ManagerController : Controller
    {
        private BumboDbContext db = new BumboDbContext();

        private void GetPrognosis(DateTime date, bool isHoliday, string departmentName) {
            DataSet dataSet = (from DataSet in db.DataSets where DataSet.DepartmentName == departmentName select DataSet).First();

            // Hourly curve and data points are not loading automatically for some reason. TODO: fix
            if(dataSet.HourlyCurve == null)
                dataSet.HourlyCurve = (from HourlyPoint in db.HourlyPoints where HourlyPoint.DepartmentName == departmentName select HourlyPoint).ToList();

            if(dataSet.DataPoints == null)
                dataSet.DataPoints = (from DataPoint in db.DataPoints where DataPoint.DepartmentName == departmentName select DataPoint).ToList();

            Prognosis prognosis;

            try
            {
                prognosis = (from Prognosis in db.Prognosis where Prognosis.Date == date && Prognosis.DepartmentName == departmentName select Prognosis).First();
            }
            catch
            { 
                prognosis = new Prognosis();
                prognosis.Date = date;
                prognosis.DepartmentName = departmentName;
                prognosis.Value = dataSet.PredictValue(date, isHoliday);

                db.Prognosis.Add(prognosis);
                db.SaveChanges();
            }

            ViewBag.EmployeePrognosis = dataSet.PredictHourlyEmployees(prognosis.Value);
        }

        public IActionResult LeaveRequests()
        {
            return View();
        }

        public IActionResult Prognosis()
        {
            return View();
        }

        public IActionResult Scheduling(string departmentName, int year, int month, int day)
        {
            try
            {
                ViewBag.Date = new DateTime(year, month, day);
                if(ViewBag.Date.Date < DateTime.Today.Date) ViewBag.Date = DateTime.Today;
            }
            catch(Exception ex)
            {
                ViewBag.Date = DateTime.Today;
            }

            Department department;
            
            try
            {
                department = (from Department in db.Departments where Department.Name == departmentName select Department).First();
            }
            catch(Exception ex)
            {
                department = (from Department in db.Departments select Department).First();
            }

            GetPrognosis(ViewBag.Date, false, department.Name);

            ViewBag.Department = department;

            ViewBag.Departments = (from Department in db.Departments select Department).ToList();

            ViewBag.StartHour = (from DataSet in db.DataSets where DataSet.DepartmentName == department.Name select DataSet.DepartmentStartHour).First();
            ViewBag.EndHour = (from DataSet in db.DataSets where DataSet.DepartmentName == department.Name select DataSet.DepartmentEndHour).First();

            ViewBag.Employees = (from Employee in db.Employees select Employee).ToList();

            switch(ViewBag.Date.DayOfWeek)
            {
                case DayOfWeek.Monday:    ViewBag.DutchDate = "Maandag";   break;
                case DayOfWeek.Tuesday:   ViewBag.DutchDate = "Dinsdag";   break;
                case DayOfWeek.Wednesday: ViewBag.DutchDate = "Woensdag";  break;
                case DayOfWeek.Thursday:  ViewBag.DutchDate = "Donderdag"; break;
                case DayOfWeek.Friday:    ViewBag.DutchDate = "Vrijdag";   break;
                case DayOfWeek.Saturday:  ViewBag.DutchDate = "Zaterdag";  break;
                case DayOfWeek.Sunday:    ViewBag.DutchDate = "Zondag";    break;
            }

            ViewBag.DutchDate += " " + ViewBag.Date.Day + " ";

            switch(ViewBag.Date.Month)
            {
                case  1: ViewBag.DutchDate += "Januari";   break;
                case  2: ViewBag.DutchDate += "Februari";  break;
                case  3: ViewBag.DutchDate += "Maart";     break;
                case  4: ViewBag.DutchDate += "April";     break;
                case  5: ViewBag.DutchDate += "Mei";       break;
                case  6: ViewBag.DutchDate += "Juni";      break;
                case  7: ViewBag.DutchDate += "Juli";      break;
                case  8: ViewBag.DutchDate += "Augustus";  break;
                case  9: ViewBag.DutchDate += "September"; break;
                case 10: ViewBag.DutchDate += "Oktober";   break;
                case 11: ViewBag.DutchDate += "November";  break;
                case 12: ViewBag.DutchDate += "December";  break;
            }

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
            int maximumDay, int maximumMonth, int maximumYear,
            string link
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

            data.Link = HttpUtility.UrlDecode(link);

            return PartialView(data);
        }
    }
}
