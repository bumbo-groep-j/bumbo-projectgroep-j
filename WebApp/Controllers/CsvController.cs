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
        [HttpPost]
        public async Task<ActionResult> ReadFromCSV(IFormCollection collection)
        {
            StreamReader reader;
            foreach (FormFile file in collection.Files)
            {
                reader = new StreamReader(file.OpenReadStream());

                string content = reader.ReadToEnd().Replace("\r", "");
                string fixedContent = "";
                if (content.Contains("/"))
                {
                    foreach (string line in content.Split("\n"))
                    {
                        if (!line.Contains("/"))
                        {
                            fixedContent += line + '\n';
                            continue;
                        }

                        var values = line.Split(",");

                        for (int i = 0; i < values.Length; i++)
                            if(values[i].Contains('/'))
                            {
                                var dateValues = values[i].Split("/");
                                values[i] = dateValues[2] + "-" + dateValues[1] + "-" + dateValues[0];
                            }

                        for (int i = 0; i < values.Length; i++)
                        {
                            fixedContent += values[i];
                            if (i != values.Length - 1)
                                fixedContent += ',';
                        }

                        fixedContent += '\n';
                    }
                }
                else fixedContent = content;

                if (file.FileName.Contains("medewerkers"))
                {

                    var contentReader = new StringReader(fixedContent);

                    var csv = new CsvReader(contentReader, CultureInfo.InvariantCulture);

                    List<Employee> records = csv.GetRecords<Employee>().ToList();

                    foreach (Employee employee in records)
                    {
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
                    if(!fixedContent.Split('\n')[0].Contains("Afdeling"))
                    {
                        content = "";
                        bool firstLine = true;

                        foreach (string line in fixedContent.Split("\n"))
                        {
                            if (firstLine)
                            {
                                content += line + ",Afdeling\n";
                                firstLine = false;
                            }
                            else if (line != "")
                            {
                                content += line + ",Kassa\n";
                            }
                        }
                    } else content = fixedContent;

                    var contentReader = new StringReader(content);

                    var csv = new CsvReader(contentReader, CultureInfo.InvariantCulture);

                    List<Schedule> records = csv.GetRecords<Schedule>().ToList();
                    int countSchedules = db.Schedules.Count() + 1;
                    foreach (Schedule schedule in records)
                    {
                        try
                        {
                            Employee employee = db.Employees.First(e => e.NFCToken == schedule.BID);
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
            return RedirectToAction("ListEmployees", "Manager");
        }
    }
}
