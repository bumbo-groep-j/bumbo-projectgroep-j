using Bumbo.Models;
using CsvHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.IO.Pipelines;
using System.Web.WebPages;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    public class CSVController : Controller
    {
        private BumboDbContext db;
        private UserManager<Account> userManager;
        public CSVController(UserManager<Account> user, BumboDbContext dbContext)
        {
            userManager = user;
            db = dbContext;
        }

        [Authorize(Roles = "Manager")]
        public ActionResult CsvImport()
        {
            return View();
        }
        [Authorize(Roles = "Manager")]
        [HttpPost]
        public async Task<ActionResult> ReadFromCSV(IFormCollection collection)
        {
            StreamReader reader;
            foreach ( FormFile file in collection.Files)
            {
                reader = new StreamReader(file.OpenReadStream());

                if (file.FileName.Contains("medewerkers"))
                {
                    var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                    List<Employee> records = csv.GetRecords<Employee>().ToList();

                    foreach (Employee employee in records)
                    {
                        employee.NFCToken = Guid.NewGuid().ToString();
                        employee.UserName = employee.FirstName + employee.LastName;
                        employee.UserName = employee.UserName.Replace(" ", "");

                        EmployeeAccount account = new EmployeeAccount();
                        account.Employee = employee;
                        account.Role = "Employee";
                        account.Account = new Account();
                        account.Account.UserName = employee.UserName;
                        account.Account.Password = "TempPassword";

                        var result = await userManager.CreateAsync(account.Account, account.Account.Password);

                        if (result.Succeeded)
                        {
                            await userManager.AddToRoleAsync(account.Account, account.Role);

                            if (account.Role == "Employee")
                            {
                                db.Employees.Add(account.Employee);
                            }
                        }

                        foreach (var error in result.Errors)
                            ModelState.AddModelError(string.Empty, error.Description);
                    }
                    db.SaveChanges();

                }
                if (file.FileName.Contains("hours"))
                {
                    var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                    List<Schedule> records = csv.GetRecords<Schedule>().ToList();
                    int countSchedules = db.Schedules.Count() + 1;
                    foreach ( Schedule schedule in records )
                    {

                        try
                        {
                            Employee employee = db.Employees.First(e => e.BID == schedule.BID);
                            schedule.Employee = employee;
                            schedule.EmployeeId = employee.Id;
                            schedule.StartTime = new DateTime(schedule.Date.Year, schedule.Date.Month, schedule.Date.Day, schedule.StartTime.Hour, schedule.StartTime.Minute, schedule.StartTime.Second);
                            schedule.EndTime = new DateTime(schedule.Date.Year, schedule.Date.Month, schedule.Date.Day, schedule.EndTime.Hour, schedule.EndTime.Minute, schedule.EndTime.Second);
                            schedule.Id = countSchedules;

                            db.Schedules.Add(schedule);
                            countSchedules++;

                            WorkedHour workedHour = new WorkedHour();
                            workedHour.ScheduleId = schedule.Id;
                            workedHour.Schedule = schedule;
                            workedHour.ClockedTimeStart = schedule.StartTime;
                            workedHour.ClockedTimeEnd = schedule.EndTime;
                            workedHour.Department = schedule.Department;

                            db.WorkedHours.Add(workedHour);
                        }
                        catch (Exception exception)
                        {
                            ModelState.AddModelError(string.Empty, "Een medewerker kon niet worden gevonden in de database");
                        }
                    }

                    db.SaveChangesWithIdentityInsert<Schedule>();
                }

            }
            return Redirect("CsvImport");
        }
    }
}
