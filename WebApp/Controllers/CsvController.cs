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
                    
                }

            }

            return RedirectToAction( "ListEmployees", "Manager" );
        }
    }
}
