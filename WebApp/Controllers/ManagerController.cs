﻿using Bumbo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Web;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    public class ManagerController : Controller
    {
        private BumboDbContext db = new BumboDbContext();
        private UserManager<Account> userManager;
        public ManagerController(UserManager<Account> user) {
            userManager = user;
        }

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

        [Authorize(Roles = "Manager")]
        public IActionResult LeaveRequests()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Prognosis()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Scheduling(string departmentName, int year, int month, int day)
        {
            DateTime date;

            try
            {
                date = new DateTime(year, month, day);
                if(date.Date < DateTime.Today.Date) date = DateTime.Today;
            }
            catch(Exception ex)
            {
                date = DateTime.Today;
            }

            ViewBag.Date = date;

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

            ScheduleForm model = new ScheduleForm();
            
            for(int i = 0; i < ViewBag.Employees.Count; i++)
                for(int hour = ViewBag.StartHour; hour <= ViewBag.EndHour; hour++)
                    model.IsChecked.Add(false);

            var existingSchedule = (
                from Schedule
                in db.Schedules
                where Schedule.StartTime.Day == date.Day && Schedule.StartTime.Month == date.Month
                && Schedule.StartTime.Year == date.Year && Schedule.Department == department.Name
                select Schedule
            ).ToList();

            int hours = ViewBag.EndHour - ViewBag.StartHour + 1;

            foreach(var schedule in existingSchedule) 
                for(int i = 0; i < ViewBag.Employees.Count; i++)
                    if(ViewBag.Employees[i].Id == schedule.EmployeeId)
                        for(int hour = schedule.StartTime.Hour; hour <= schedule.EndTime.Hour; hour++)
                            model.IsChecked[i * hours + hour - ViewBag.StartHour] = true;

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        public IActionResult Scheduling(ScheduleForm model)
        {
            try
            {
                var existingSchedule = (
                    from Schedule
                    in db.Schedules
                    where Schedule.StartTime.Day == model.Day && Schedule.StartTime.Month == model.Month
                    && Schedule.StartTime.Year == model.Year && Schedule.Department == model.DepartmentName
                    select Schedule
                ).ToList();

                foreach(var s in existingSchedule) db.Schedules.Remove(s);

                var employees = (from Employee in db.Employees select Employee).ToList();

                Schedule? schedule = null;

                int startHour = (from DataSet in db.DataSets where DataSet.DepartmentName == model.DepartmentName select DataSet.DepartmentStartHour).First();
                int endHour = (from DataSet in db.DataSets where DataSet.DepartmentName == model.DepartmentName select DataSet.DepartmentEndHour).First();
                int hours = endHour - startHour + 1;

                for(int i = 0; i < model.IsChecked.Count; i++)
                {
                    int curHour = i % hours;

                    if(model.IsChecked[i] && schedule == null)
                    {
                        schedule = new Schedule();
                        schedule.StartTime = new DateTime(model.Year, model.Month, model.Day, curHour + startHour, 0, 0);
                        schedule.EmployeeId = employees[i / hours].Id;
                        schedule.Department = model.DepartmentName;
                    }

                    else if(schedule != null && (!model.IsChecked[i] || curHour == 0))
                    {
                        schedule.EndTime = new DateTime(model.Year, model.Month, model.Day, (i - 1) % hours + startHour, 59, 59);
                        db.Schedules.Add(schedule);
                        schedule = null;
                    }
                }

                if(schedule != null)
                {
                    schedule.EndTime = new DateTime(model.Year, model.Month, model.Day, endHour, 59, 59);
                    db.Schedules.Add(schedule);
                }

                db.SaveChanges();
            }
            catch(Exception ex) { }

            return Scheduling(model.DepartmentName, model.Year, model.Month, model.Day);
        }

        [Authorize(Roles = "Manager")]
        public IActionResult WorkedHours(int year, int month, int day)
        {
            DateTime date;

            try
            {
                date = new DateTime(year, month, day);
                if(date.Date > DateTime.Today.Date) date = DateTime.Today;
            }
            catch(Exception ex)
            {
                date = DateTime.Today;
            }

            ViewBag.Date = date;

            switch(ViewBag.Date.DayOfWeek)
            {
                case DayOfWeek.Monday: ViewBag.DutchDate = "Maandag"; break;
                case DayOfWeek.Tuesday: ViewBag.DutchDate = "Dinsdag"; break;
                case DayOfWeek.Wednesday: ViewBag.DutchDate = "Woensdag"; break;
                case DayOfWeek.Thursday: ViewBag.DutchDate = "Donderdag"; break;
                case DayOfWeek.Friday: ViewBag.DutchDate = "Vrijdag"; break;
                case DayOfWeek.Saturday: ViewBag.DutchDate = "Zaterdag"; break;
                case DayOfWeek.Sunday: ViewBag.DutchDate = "Zondag"; break;
            }

            ViewBag.DutchDate += " " + ViewBag.Date.Day + " ";

            switch(ViewBag.Date.Month)
            {
                case 1: ViewBag.DutchDate += "Januari"; break;
                case 2: ViewBag.DutchDate += "Februari"; break;
                case 3: ViewBag.DutchDate += "Maart"; break;
                case 4: ViewBag.DutchDate += "April"; break;
                case 5: ViewBag.DutchDate += "Mei"; break;
                case 6: ViewBag.DutchDate += "Juni"; break;
                case 7: ViewBag.DutchDate += "Juli"; break;
                case 8: ViewBag.DutchDate += "Augustus"; break;
                case 9: ViewBag.DutchDate += "September"; break;
                case 10: ViewBag.DutchDate += "Oktober"; break;
                case 11: ViewBag.DutchDate += "November"; break;
                case 12: ViewBag.DutchDate += "December"; break;
            }

            List<ClockedHour> model = (
                from WorkedHour
                in db.WorkedHours
                from Schedule
                in db.Schedules
                where Schedule.Id == WorkedHour.ScheduleId
                where WorkedHour.ClockedTimeStart.Date == date
                select new ClockedHour
                {
                    Id = WorkedHour.Id,
                    Name = Schedule.Employee.Name,
                    ScheduledStartTime = Schedule.StartTime,
                    ScheduledEndTime = Schedule.EndTime,
                    ClockedStartTime = WorkedHour.ClockedTimeStart,
                    ClockedEndTime = WorkedHour.ClockedTimeEnd,
                    ApprovedStartTime = WorkedHour.ApprovedTimeStart,
                    ApprovedEndTime = WorkedHour.ApprovedTimeEnd,
                    ApprovalTime = WorkedHour.ApprovalTime,
                    WorkedHours = WorkedHour.ApprovedTimeStart != null ? WorkedHour.ApprovedTimeEnd - WorkedHour.ApprovedTimeStart : WorkedHour.ClockedTimeEnd - WorkedHour.ClockedTimeStart,
                    TimeDifference = (
                        (
                            (WorkedHour.ApprovedTimeStart != null ? WorkedHour.ApprovedTimeEnd - WorkedHour.ApprovedTimeStart : WorkedHour.ClockedTimeEnd - WorkedHour.ClockedTimeStart)
                          - (Schedule.EndTime - Schedule.StartTime)
                        ).Value.Hours < 0
                     || (
                            (WorkedHour.ApprovedTimeStart != null ? WorkedHour.ApprovedTimeEnd - WorkedHour.ApprovedTimeStart : WorkedHour.ClockedTimeEnd - WorkedHour.ClockedTimeStart)
                          - (Schedule.EndTime - Schedule.StartTime)
                        ).Value.Minutes < 0 ? "-" : "+"
                    )
                  + Math.Abs((
                        (WorkedHour.ApprovedTimeStart != null ? WorkedHour.ApprovedTimeEnd - WorkedHour.ApprovedTimeStart : WorkedHour.ClockedTimeEnd - WorkedHour.ClockedTimeStart)
                      - (Schedule.EndTime - Schedule.StartTime)
                    ).Value.Hours) + ":"
                  + (Math.Abs((
                            (WorkedHour.ApprovedTimeStart != null ? WorkedHour.ApprovedTimeEnd - WorkedHour.ApprovedTimeStart : WorkedHour.ClockedTimeEnd - WorkedHour.ClockedTimeStart)
                          - (Schedule.EndTime - Schedule.StartTime)
                        ).Value.Minutes) < 10 ? "0" : ""
                    )
                  + Math.Abs((
                        (WorkedHour.ApprovedTimeStart != null ? WorkedHour.ApprovedTimeEnd - WorkedHour.ApprovedTimeStart : WorkedHour.ClockedTimeEnd - WorkedHour.ClockedTimeStart)
                      - (Schedule.EndTime - Schedule.StartTime)
                    ).Value.Minutes)
                }
            ).ToList();

            return View(model);
        }

        [Authorize(Roles = "Manager")]
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

        [Authorize(Roles = "Manager")]
        public IActionResult EditWorkedHours(int year, int month, int day, int id) 
        {
            ApprovedHoursForm data = (
                from WorkedHour
                in db.WorkedHours
                from Schedule
                in db.Schedules
                where Schedule.Id == WorkedHour.ScheduleId
                where WorkedHour.Id == id
                select new ApprovedHoursForm
                {
                    Year = year,
                    Month = month,
                    Day = day,
                    WorkedHourId = WorkedHour.Id,
                    StartTime = new DateTime(year, month, day, (WorkedHour.ApprovedTimeStart ?? WorkedHour.ClockedTimeStart).Hour, (WorkedHour.ApprovedTimeStart ?? WorkedHour.ClockedTimeStart).Minute, 0),
                    EndTime = new DateTime(year, month, day, (WorkedHour.ApprovedTimeEnd ?? WorkedHour.ClockedTimeEnd.Value).Hour, (WorkedHour.ApprovedTimeEnd ?? WorkedHour.ClockedTimeEnd.Value).Minute, 0),
                }
            ).First();

            return PartialView(data);
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        public void EditHours(ApprovedHoursForm form) 
        {
            WorkedHour value = (from WorkedHour in db.WorkedHours where WorkedHour.Id == form.WorkedHourId select WorkedHour).First();

            value.ApprovedTimeStart = new DateTime(value.ClockedTimeStart.Year, value.ClockedTimeStart.Month, value.ClockedTimeStart.Day, form.StartTime.Hour, form.StartTime.Minute, form.StartTime.Second);
            value.ApprovedTimeEnd = new DateTime(value.ClockedTimeEnd.Value.Year, value.ClockedTimeEnd.Value.Month, value.ClockedTimeEnd.Value.Day, form.EndTime.Hour, form.EndTime.Minute, form.EndTime.Second);

            db.SaveChanges();
        }

        [Authorize(Roles = "Manager")]
        public void ApproveHours(int id)
        {
            WorkedHour value = (from WorkedHour in db.WorkedHours where WorkedHour.Id == id select WorkedHour).First();
            value.ApprovalTime = DateTime.Now;

            if(!value.ApprovedTimeStart.HasValue) value.ApprovedTimeStart = value.ClockedTimeStart;
            if(!value.ApprovedTimeEnd.HasValue) value.ApprovedTimeEnd = value.ClockedTimeEnd.Value;

            db.SaveChanges();
        }

        [Authorize(Roles = "Manager")]
        public void ApproveAllHours(int year, int month, int day)
        {
            var values = (from WorkedHour in db.WorkedHours where WorkedHour.ClockedTimeStart.Year == year && WorkedHour.ClockedTimeStart.Month == month && WorkedHour.ClockedTimeStart.Day == day select WorkedHour).ToList();

            foreach(var value in values)
            {
                if(!value.ApprovalTime.HasValue)
                {
                    value.ApprovalTime = DateTime.Now;

                    if(!value.ApprovedTimeStart.HasValue) value.ApprovedTimeStart = value.ClockedTimeStart;
                    if(!value.ApprovedTimeEnd.HasValue) value.ApprovedTimeEnd = value.ClockedTimeEnd.Value;
                }
            }

            db.SaveChanges(); 
        }

        [Authorize(Roles = "Manager")]
        public IActionResult ListEmployees()
        {
            return View((
                from Account
                in db.Users
                select new EmployeeAccount
                {
                    Account = Account,
                    Employee = (from Employee in db.Employees where Employee.UserName == Account.UserName select Employee).First(),
                    Role = userManager.GetRolesAsync(Account).Result.FirstOrDefault()
                }
            ));
        }

        [Authorize(Roles = "Manager")]
        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> CreateEmployee(EmployeeAccount model)
        {
            if(model.Role == "Employee")
                model.Employee.UserName = model.Account.Username;
            else
                model.Employee = null;

            model.Account.UserName  = model.Account.Username;
            ModelState.Clear();
            TryValidateModel(model);
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await userManager.CreateAsync(model.Account, model.Account.Password);

                    if(result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(model.Account, model.Role);

                        if(model.Role == "Employee")
                        {
                            db.Employees.Add(model.Employee);
                            db.SaveChanges();
                        }

                        return RedirectToAction("ListEmployees");
                    }

                    foreach(var error in result.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            catch { }

            return View(model);
        }

        [Authorize(Roles = "Manager")]
        public IActionResult EditEmployee(string userName)
        {
            try
            {
                return View((from Employee in db.Employees where Employee.UserName == userName select Employee).First());
            }
            catch { }

            return RedirectToAction("ListEmployees");
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        public IActionResult EditEmployee(Employee model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var employee = (from Employee in db.Employees where Employee.UserName == model.UserName select Employee).First();

                    employee.FirstName = model.FirstName;
                    employee.MiddleName = model.MiddleName;
                    employee.LastName = model.LastName;
                    employee.DateOfBirth = model.DateOfBirth;
                    employee.NFCToken = model.NFCToken;
                    employee.HourlyWage = model.HourlyWage;

                    db.SaveChanges();

                    return RedirectToAction("ListEmployees");
                }
            }
            catch { }

            return View(model);
        }

        [Authorize(Roles = "Manager")]
        public IActionResult DeleteEmployee(string userName) {
            try {
                return View((from Employee in db.Employees where Employee.UserName == userName select Employee).First());
            } catch { }

            return RedirectToAction("ListEmployees");
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        public IActionResult DeleteEmployee(Employee model) {
            try {
                var employee = (from Employee in db.Employees where Employee.UserName == model.UserName select Employee).First();

                employee.Inactive = true;

                db.SaveChanges();

                return RedirectToAction("ListEmployees");
            } catch { }

            return View(model);
        }

        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeleteManager(string userName) {
            try {
                return View(await userManager.FindByNameAsync(userName));
            } catch { }

            return RedirectToAction("ListEmployees");
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeleteManager(Account model) {
            try {
                await userManager.DeleteAsync(await userManager.FindByNameAsync(model.UserName));

                return RedirectToAction("ListEmployees");
            } catch { }

            return View(model);
        }
    }
}
