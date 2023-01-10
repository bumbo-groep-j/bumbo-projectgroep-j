using Bumbo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    public class ManagerController : Controller
    {
        private BumboDbContext db;
        private UserManager<Account> userManager;
        public ManagerController(UserManager<Account> user, BumboDbContext dbContext)
        {
            userManager = user;
            db = dbContext;
        }

        private (Prognosis, DataSet) GetPrognosis(DateTime date, bool isHoliday, string departmentName)
        {
            DataSet dataSet = (from DataSet in db.DataSets where DataSet.DepartmentName == departmentName select DataSet).First();

            // Hourly curve and data points are not loading automatically for some reason. TODO: fix
            if (dataSet.HourlyCurve == null)
                dataSet.HourlyCurve = (from HourlyPoint in db.HourlyPoints where HourlyPoint.DepartmentName == departmentName select HourlyPoint).ToList();

            if (dataSet.DataPoints == null)
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
                prognosis.Value = dataSet.ShouldEstimateValue ? dataSet.PredictValue(date, isHoliday) : 0;

                db.Prognosis.Add(prognosis);
                db.SaveChanges();
            }

            return (prognosis, dataSet);
        }


        [Authorize(Roles = "Manager")]
        public IActionResult LeaveRequests()
        {

            ViewBag.IsEmpty = !db.LeaveRequests.Any();

            ViewBag.Requests = (from LeaveRequest in db.LeaveRequests
                                join Employee in db.Employees
                                on LeaveRequest.EmployeeId equals Employee.Id
                                select Tuple.Create(LeaveRequest, Employee)).ToList();

            return View();

        }

        [Authorize(Roles = "Manager")]
        public IActionResult ApproveLeaveRequest(int id)
        {
            var request = db.LeaveRequests.FirstOrDefault(r => r.Id == id);

            if (request != null)
            {
                request.Approved = true;
                db.SaveChanges();

                return RedirectToAction("LeaveRequests");
            }
            return View(request);
        }

        [Authorize(Roles = "Manager")]
        public IActionResult RejectLeaveRequest(int id)
        {

            var request = db.LeaveRequests.FirstOrDefault(r => r.Id == id);

            if (request != null)
            {
                request.Rejected = true;
                db.SaveChanges();
                return RedirectToAction("LeaveRequests");
            }
            return View(request);
        }

        private string GetDutchDate(DateTime date)
        {
            string dutchDate = "";

            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:    dutchDate = "Maandag";   break;
                case DayOfWeek.Tuesday:   dutchDate = "Dinsdag";   break;
                case DayOfWeek.Wednesday: dutchDate = "Woensdag";  break;
                case DayOfWeek.Thursday:  dutchDate = "Donderdag"; break;
                case DayOfWeek.Friday:    dutchDate = "Vrijdag";   break;
                case DayOfWeek.Saturday:  dutchDate = "Zaterdag";  break;
                case DayOfWeek.Sunday:    dutchDate = "Zondag";    break;
            }

            dutchDate += " " + date.Day + " ";

            switch (date.Month)
            {
                case  1: dutchDate += "Januari";   break;
                case  2: dutchDate += "Februari";  break;
                case  3: dutchDate += "Maart";     break;
                case  4: dutchDate += "April";     break;
                case  5: dutchDate += "Mei";       break;
                case  6: dutchDate += "Juni";      break;
                case  7: dutchDate += "Juli";      break;
                case  8: dutchDate += "Augustus";  break;
                case  9: dutchDate += "September"; break;
                case 10: dutchDate += "Oktober";   break;
                case 11: dutchDate += "November";  break;
                case 12: dutchDate += "December";  break;
            }

            return dutchDate;
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Prognosis(string departmentName, int year, int month, int day)
        {
            DateTime date;

            try
            {
                date = new DateTime(year, month, day);
            }
            catch (Exception ex)
            {
                date = DateTime.Today;
            }

            if(date.DayOfWeek == DayOfWeek.Sunday)
                date = date.AddDays(-6);
            else
                date = date.AddDays(1 - (int)date.DayOfWeek);

            ViewBag.StartDate = date;
            ViewBag.StartDutchDate = GetDutchDate(date);

            ViewBag.EndDate = date.AddDays(6);
            ViewBag.EndDutchDate = GetDutchDate(date.AddDays(6));

            var model = new PrognosisForm();
            model.Prognoses = new Prognosis[7];

            ViewBag.Dates = new DateTime[7];
            ViewBag.DutchDates = new string[7];

            Department department;

            try
            {
                department = (from Department in db.Departments where Department.Name == departmentName select Department).First();
            }
            catch (Exception ex)
            {
                department = (from Department in db.Departments select Department).First();
            }

            ViewBag.Department = department;

            ViewBag.Departments = (from Department in db.Departments select Department).ToList();

            for (int i = 0; i < 7; i++)
            {
                ViewBag.Dates[i] = date.AddDays(i);
                (model.Prognoses[i], DataSet dataSet) = ((Prognosis, DataSet)) GetPrognosis(ViewBag.Dates[i], false, department.Name);

                switch (ViewBag.Dates[i].DayOfWeek)
                {
                    case DayOfWeek.Monday:    ViewBag.DutchDates[i] = "Ma"; break;
                    case DayOfWeek.Tuesday:   ViewBag.DutchDates[i] = "Di"; break;
                    case DayOfWeek.Wednesday: ViewBag.DutchDates[i] = "Wo"; break;
                    case DayOfWeek.Thursday:  ViewBag.DutchDates[i] = "Do"; break;
                    case DayOfWeek.Friday:    ViewBag.DutchDates[i] = "Vr"; break;
                    case DayOfWeek.Saturday:  ViewBag.DutchDates[i] = "Za"; break;
                    case DayOfWeek.Sunday:    ViewBag.DutchDates[i] = "Zo"; break;
                }

                ViewBag.DutchDates[i] += " " + ViewBag.Dates[i].Day + " ";

                switch (ViewBag.Dates[i].Month)
                {
                    case  1: ViewBag.DutchDates[i] += "Januari";   break;
                    case  2: ViewBag.DutchDates[i] += "Februari";  break;
                    case  3: ViewBag.DutchDates[i] += "Maart";     break;
                    case  4: ViewBag.DutchDates[i] += "April";     break;
                    case  5: ViewBag.DutchDates[i] += "Mei";       break;
                    case  6: ViewBag.DutchDates[i] += "Juni";      break;
                    case  7: ViewBag.DutchDates[i] += "Juli";      break;
                    case  8: ViewBag.DutchDates[i] += "Augustus";  break;
                    case  9: ViewBag.DutchDates[i] += "September"; break;
                    case 10: ViewBag.DutchDates[i] += "Oktober";   break;
                    case 11: ViewBag.DutchDates[i] += "November";  break;
                    case 12: ViewBag.DutchDates[i] += "December";  break;
                }
            }

            ViewBag.ValueName = (from Department in db.Departments where Department.Name == department.Name select Department.PredictionValueName).First();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        public IActionResult Prognosis(PrognosisForm model)
        {
            foreach (var prognosis in model.Prognoses)
            {
                var dbPrognosis = (from Prognosis in db.Prognosis where Prognosis.Id == prognosis.Id select Prognosis).First();
                dbPrognosis.Value = prognosis.Value;
            }
            db.SaveChanges();

            return Prognosis(model.Prognoses[0].DepartmentName, model.Prognoses[0].Date.Year, model.Prognoses[0].Date.Month, model.Prognoses[0].Date.Day);
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Scheduling(string departmentName, int year, int month, int day)
        {
            DateTime date;

            try
            {
                date = new DateTime(year, month, day);
                if (date.Date < DateTime.Today.Date) date = DateTime.Today;
            }
            catch (Exception ex)
            {
                date = DateTime.Today;
            }

            ViewBag.Date = date;

            ViewBag.DutchDate = GetDutchDate(date);

            Department department;

            try
            {
                department = (from Department in db.Departments where Department.Name == departmentName select Department).First();
            }
            catch (Exception ex)
            {
                department = (from Department in db.Departments select Department).First();
            }

            (Prognosis prognosis, DataSet dataSet) = ((Prognosis, DataSet)) GetPrognosis(ViewBag.Date, false, department.Name);

            ViewBag.EmployeePrognosis = dataSet.PredictHourlyEmployees(prognosis.Value);

            ViewBag.Department = department;

            ViewBag.Departments = (from Department in db.Departments select Department).ToList();

            ViewBag.StartHour = (from DataSet in db.DataSets where DataSet.DepartmentName == department.Name select DataSet.DepartmentStartHour).First();
            ViewBag.EndHour = (from DataSet in db.DataSets where DataSet.DepartmentName == department.Name select DataSet.DepartmentEndHour).First();

            ViewBag.Employees = (from Employee in db.Employees where !Employee.Inactive && Employee.Role == "Employee" select Employee).ToList();

            ScheduleForm model = new ScheduleForm();

            model.Availabilities = (
                from Availability in db.Availabilities
                where Availability.StartDate <= date
                && (Availability.EndDate == null || Availability.EndDate > date)
                && Availability.Weekday == Enum.Parse<Weekday>(date.DayOfWeek.ToString())
                select Availability
            ).ToList();

            model.Schedules = (
                from Schedule in db.Schedules
                where Schedule.StartTime.Date == date
                && Schedule.Department != department.Name
                select Schedule
            ).ToList();

            for (int i = 0; i < ViewBag.Employees.Count; i++)
                for (int hour = ViewBag.StartHour; hour <= ViewBag.EndHour; hour++)
                    model.IsChecked.Add(false);

            var existingSchedule = (
                from Schedule
                in db.Schedules
                where Schedule.StartTime.Date == date
                && Schedule.Department == department.Name
                select Schedule
            ).ToList();

            int hours = ViewBag.EndHour - ViewBag.StartHour + 1;

            foreach (var schedule in existingSchedule)
                for (int i = 0; i < ViewBag.Employees.Count; i++)
                    if (ViewBag.Employees[i].Id == schedule.EmployeeId)
                        for (int hour = schedule.StartTime.Hour; hour <= schedule.EndTime.Hour; hour++)
                            model.IsChecked[i * hours + hour - ViewBag.StartHour] = true;

            var regulations = (from CAORegulation in db.CAORegulations orderby CAORegulation.Age descending select CAORegulation).ToList();

            ViewBag.EmployeeIds = (from Employee in db.Employees where !Employee.Inactive && Employee.Role == "Employee" select Employee.Id).ToList();

            foreach(Employee employee in ViewBag.Employees)
            {
                employee.OnLeave = (
                    from LeaveRequest
                    in db.LeaveRequests
                    where LeaveRequest.EmployeeId == employee.Id
                    && LeaveRequest.StartDate <= date
                    && LeaveRequest.EndDate >= date
                    && LeaveRequest.Approved == true
                    select LeaveRequest
                ).Any();

                employee.CanWork = employee.DateOfBirth.AddYears(department.MinimumAge) <= DateTime.Today && !employee.OnLeave;

                if(employee.DateOfBirth.AddYears(18) <= DateTime.Today)
                {
                    employee.AllowedHoursToday  =  24;
                    employee.AllowedHoursWeek   = 168;
                    employee.AllowedHours4Weeks = 672;
                }
                else
                {
                    employee.AllowedHoursToday  = 0;
                    employee.AllowedHoursWeek   = 0;
                    employee.AllowedHours4Weeks = 0;

                    int workedHoursToday  = 0;
                    int workedHoursWeek   = 0;
                    int workedHours4Weeks = 0;

                    foreach(var schedule in (
                        from Schedule
                        in db.Schedules
                        where Schedule.StartTime.Date == date
                        && Schedule.EmployeeId == employee.Id
                        select Schedule
                    )) if(!existingSchedule.Contains(schedule)) workedHoursToday += schedule.EndTime.Hour - schedule.StartTime.Hour;

                    foreach(var schedule in (
                        from Schedule
                        in db.Schedules
                        where Schedule.StartTime.Date >= date.AddDays(1 - (int)date.DayOfWeek)
                        && Schedule.StartTime.Date <= date.AddDays(7 - (int)date.DayOfWeek)
                        && Schedule.EmployeeId == employee.Id
                        select Schedule
                    )) if(!existingSchedule.Contains(schedule)) workedHoursWeek += schedule.EndTime.Hour - schedule.StartTime.Hour;

                    foreach(var schedule in (
                        from Schedule
                        in db.Schedules
                        where Schedule.StartTime.Date >= date.AddDays(-20 - (int)date.DayOfWeek)
                        && Schedule.StartTime.Date <= date.AddDays(7 - (int)date.DayOfWeek)
                        && Schedule.EmployeeId == employee.Id
                        select Schedule
                    )) if(!existingSchedule.Contains(schedule)) workedHours4Weeks += schedule.EndTime.Hour - schedule.StartTime.Hour;

                    bool schoolDay = !(
                        from SchoolHoliday
                        in db.SchoolHolidays
                        where SchoolHoliday.StartDate <= date
                        && SchoolHoliday.EndDate > date
                        select SchoolHoliday
                    ).Any() && (
                        from SchoolSchedule
                        in db.SchoolSchedules
                        where SchoolSchedule.Weekday == Enum.Parse<Weekday>(date.DayOfWeek.ToString())
                        && SchoolSchedule.StartDate <= date
                        && (SchoolSchedule.EndDate == null || SchoolSchedule.EndDate > date)
                        && SchoolSchedule.EmployeeId == employee.Id
                        select SchoolSchedule
                    ).Any();

                    bool schoolWeek = !(
                        from SchoolHoliday
                        in db.SchoolHolidays
                        where SchoolHoliday.StartDate <= date
                        && SchoolHoliday.EndDate > date
                        select SchoolHoliday
                    ).Any() && (
                        from SchoolSchedule
                        in db.SchoolSchedules
                        where SchoolSchedule.StartDate <= date
                        && (SchoolSchedule.EndDate == null || SchoolSchedule.EndDate > date)
                        && SchoolSchedule.EmployeeId == employee.Id
                        select SchoolSchedule
                    ).Any();

                    foreach(var regulation in regulations)
                    {
                        if(employee.DateOfBirth.AddYears(regulation.Age) <= DateTime.Today)
                        {
                            if(schoolDay)
                            {
                                employee.AllowedHoursToday = regulation.AllowedHoursSchoolDay;
                                employee.AllowedHoursWeek  = regulation.AllowedHoursSchoolWeek;
                            }
                            else
                            {
                                employee.AllowedHoursToday = regulation.AllowedHoursNotSchoolDay;
                                employee.AllowedHoursWeek  = regulation.AllowedHoursNotSchoolWeek;
                            }

                            employee.AllowedHours4Weeks  = regulation.AllowedHours4Weeks;

                            employee.AllowedHoursToday  -= workedHoursToday;
                            employee.AllowedHoursWeek   -= workedHoursWeek;
                            employee.AllowedHours4Weeks -= workedHours4Weeks;

                            break;
                        }
                    }
                }
            }

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

                foreach (var s in existingSchedule) db.Schedules.Remove(s);

                var employees = (from Employee in db.Employees where !Employee.Inactive && Employee.Role == "Employee" select Employee).ToList();

                Schedule? schedule = null;

                int startHour = (from DataSet in db.DataSets where DataSet.DepartmentName == model.DepartmentName select DataSet.DepartmentStartHour).First();
                int endHour = (from DataSet in db.DataSets where DataSet.DepartmentName == model.DepartmentName select DataSet.DepartmentEndHour).First();
                int hours = endHour - startHour + 1;

                for (int i = 0; i < model.IsChecked.Count; i++)
                {
                    int curHour = i % hours;

                    if(schedule != null && (!model.IsChecked[i] || curHour == 0))
                    {
                        schedule.EndTime = new DateTime(model.Year, model.Month, model.Day, (i - 1) % hours + startHour, 59, 59);
                        db.Schedules.Add(schedule);
                        schedule = null;
                    }

                    if (model.IsChecked[i] && schedule == null)
                    {
                        schedule = new Schedule();
                        schedule.StartTime = new DateTime(model.Year, model.Month, model.Day, curHour + startHour, 0, 0);
                        schedule.EmployeeId = employees[i / hours].Id;
                        schedule.Department = model.DepartmentName;
                    }
                }

                if (schedule != null)
                {
                    schedule.EndTime = new DateTime(model.Year, model.Month, model.Day, endHour, 59, 59);
                    db.Schedules.Add(schedule);
                }

                db.SaveChanges();
            }
            catch (Exception ex) { }

            return Scheduling(model.DepartmentName, model.Year, model.Month, model.Day);
        }

        [Authorize(Roles = "Manager")]
        public IActionResult WorkedHours(int year, int month, int day, int pageId, int optionsPerPage)
        {
            DateTime date;

            try
            {
                date = new DateTime(year, month, day);
                if (date.Date > DateTime.Today.Date) date = DateTime.Today;
            }
            catch (Exception ex)
            {
                date = DateTime.Today;
            }

            ViewBag.Date = date;

            ViewBag.DutchDate = GetDutchDate(date);

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

            if(optionsPerPage < 10) optionsPerPage = 10;

            ViewBag.PageCount = model.Count / optionsPerPage;
            if(model.Count % optionsPerPage != 0) ViewBag.PageCount++;

            ViewBag.PageId = pageId;
            if(ViewBag.PageId > ViewBag.PageCount) ViewBag.PageId = ViewBag.PageCount;
            if(ViewBag.PageId <= 0) ViewBag.PageId = 1;

            ViewBag.OptionsPerPage = optionsPerPage;

            List<ClockedHour> realModel = new List<ClockedHour>();

            for(int i = (ViewBag.PageId - 1) * optionsPerPage; i < ViewBag.PageId * optionsPerPage && i < model.Count; i++)
                realModel.Add(model[i]);

            double bonus = 0.0;
            var bonuses = (from CAOBonuses in db.CAOBonuses orderby CAOBonuses.ValidSince descending select CAOBonuses).First();

            if(date.DayOfWeek == DayOfWeek.Sunday) bonus = bonuses.SundayBonus;
            if((from PublicHoliday in db.PublicHolidays where PublicHoliday.Date == date select PublicHoliday).Any()) bonus = bonuses.HolidayBonus;

            ViewBag.Bonus = bonus;

            return View(realModel);
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

            if (!value.ApprovedTimeStart.HasValue) value.ApprovedTimeStart = value.ClockedTimeStart;
            if (!value.ApprovedTimeEnd.HasValue) value.ApprovedTimeEnd = value.ClockedTimeEnd.Value;

            db.SaveChanges();
        }

        [Authorize(Roles = "Manager")]
        public void ApproveAllHours(int year, int month, int day)
        {
            var values = (from WorkedHour in db.WorkedHours where WorkedHour.ClockedTimeStart.Year == year && WorkedHour.ClockedTimeStart.Month == month && WorkedHour.ClockedTimeStart.Day == day select WorkedHour).ToList();

            foreach (var value in values)
            {
                if (!value.ApprovalTime.HasValue)
                {
                    value.ApprovalTime = DateTime.Now;

                    if (!value.ApprovedTimeStart.HasValue) value.ApprovedTimeStart = value.ClockedTimeStart;
                    if (!value.ApprovedTimeEnd.HasValue) value.ApprovedTimeEnd = value.ClockedTimeEnd.Value;
                }
            }

            db.SaveChanges();
        }

        [Authorize(Roles = "Manager")]
        public string ExportAllHours(int year, int month, int day) {
            var values = (from WorkedHour in db.WorkedHours where WorkedHour.ClockedTimeStart.Year == year && WorkedHour.ClockedTimeStart.Month == month && WorkedHour.ClockedTimeStart.Day == day select WorkedHour).ToList();

            string csv = "Voornaam,Tussenvoegsel,Achternaam,Datum,Starttijd,Eindtijd,Gewerkte uren,Afdeling,Toeslag\n";
            double bonus = 0.0;
            var bonuses = (from CAOBonuses in db.CAOBonuses orderby CAOBonuses.ValidSince descending select CAOBonuses).First();

            if(new DateTime(year, month, day).DayOfWeek == DayOfWeek.Sunday) bonus = bonuses.SundayBonus;
            if((from PublicHoliday in db.PublicHolidays where PublicHoliday.Date == new DateTime(year, month, day) select PublicHoliday).Any()) bonus = bonuses.HolidayBonus;

            foreach(var value in values) {
                if(value.ApprovalTime.HasValue) {
                    var employee = (from Employee in db.Employees
                                    join Schedule in db.Schedules
                                    on Employee.Id equals Schedule.EmployeeId
                                    where Schedule.Id == value.ScheduleId
                                    select Employee).First();
                    
                    value.ApprovalTime = DateTime.Now;

                    csv += employee.FirstName + ","
                        +  employee.MiddleName + ","
                        +  employee.LastName + "," 
                        +  day + "-" + month + "-" + year + ","
                        +  value.ApprovedTimeStart.Value.ToString("HH:mm:ss") + ","
                        +  value.ApprovedTimeEnd.Value.ToString("HH:mm:ss") + ","
                        + (value.ApprovedTimeEnd.Value - value.ApprovedTimeStart.Value).ToString("hh\\:mm") + ","
                        +  value.Department + ","
                        + (int)(bonus * 100.0) + "%\n";
                }
            }

            db.SaveChanges();
            return csv;
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
            ViewBag.Guid = Guid.NewGuid().ToString();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> CreateEmployee(EmployeeAccount model)
        {
            model.Employee.UserName = model.Account.Username;
            model.Employee.Role = model.Role;
            model.Account.UserName = model.Account.Username;
            ModelState.Clear();
            TryValidateModel(model);
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await userManager.CreateAsync(model.Account, model.Account.Password);

                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(model.Account, model.Role);

                        db.Employees.Add(model.Employee);
                        db.SaveChanges();

                        return RedirectToAction("ListEmployees");
                    }

                    foreach (var error in result.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            catch { }

            return View(model);
        }

        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> EditEmployee(string userName)
        {
            try
            {
                Employee model = (from Employee in db.Employees where Employee.UserName == userName select Employee).First();
                model.Role = (await userManager.GetRolesAsync(await userManager.FindByNameAsync(userName))).First();
                return View(model);
            }
            catch { }

            return RedirectToAction("ListEmployees");
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> EditEmployee(Employee model)
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
                    employee.Inactive = model.Inactive;
                    employee.Role = model.Role;

                    Account account = await userManager.FindByNameAsync(employee.UserName);

                    try
                    {
                        await userManager.RemoveFromRoleAsync(account, (await userManager.GetRolesAsync(account)).First());
                    }
                    catch(ArgumentNullException) { }

                    await userManager.AddToRoleAsync(account, model.Role);

                    db.SaveChanges();
                    return RedirectToAction("ListEmployees");
                }
            }
            catch { }

            return View(model);
        }

        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeleteManager(string userName)
        {
            try
            {
                return View(await userManager.FindByNameAsync(userName));
            }
            catch { }

            return RedirectToAction("ListEmployees");
        }

        [HttpPost]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeleteManager(Account model)
        {
            try
            {
                await userManager.DeleteAsync(await userManager.FindByNameAsync(model.UserName));

                return RedirectToAction("ListEmployees");
            }
            catch { }

            return View(model);
        }

        [Authorize(Roles = "Manager")]
        public string GenerateToken(Account model) {
            return Guid.NewGuid().ToString();
        }

        [Authorize(Roles = "Manager")]
        public List<string> GetScheduledDays(string departmentName)
        {
            List<string> scheduledDays = new List<string>();

            foreach(DateTime date in (from Schedule
                                      in db.Schedules
                                      where Schedule.Department == departmentName   
                                      select Schedule.StartTime.Date).Distinct())
            {
                (Prognosis prognosis, DataSet dataSet) = ((Prognosis, DataSet))GetPrognosis(date, false, departmentName);
                int[] predictedEmployees = dataSet.PredictHourlyEmployees(prognosis.Value);

                bool correct = true;

                for(int i = 0; i < 24; i++)
                {
                    int actualEmployees = 0;

                    foreach(Schedule schedule in (from Schedule
                                                  in db.Schedules
                                                  where Schedule.Department == departmentName
                                                  && Schedule.StartTime <= date.AddHours(i)
                                                  && Schedule.EndTime > date.AddHours(i)
                                                  select Schedule))
                        actualEmployees++;

                    if(actualEmployees != predictedEmployees[i]) { correct = false; break; }
                }

                if(correct) scheduledDays.Add(date.ToString("dd-MM-yyyy"));
            }

            return scheduledDays;
        }

        [Authorize(Roles = "Manager")]
        public List<string> GetApprovedDays()
        {
            List<string> approvedDays = new List<string>();

            foreach(DateTime date in (from WorkedHour
                                      in db.WorkedHours
                                      where WorkedHour.ApprovalTime != null
                                      select WorkedHour.ClockedTimeStart.Date).Distinct())
            {
                if(!(from WorkedHour
                     in db.WorkedHours
                     where WorkedHour.ApprovalTime == null
                     select WorkedHour.ClockedTimeStart.Date).Any())
                    approvedDays.Add(date.ToString("dd-MM-yyyy"));
            }

            return approvedDays;
        }

        [Authorize(Roles = "Manager")]
        public ActionResult CSVImport() {
            return PartialView();
        }
    }
}
