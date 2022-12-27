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

        public CSVController()
        {
            //TODO files uitlezen.
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
                        EmployeeAccount account = new EmployeeAccount();
                        account.Employee = employee;
                        account.Role = "Employee";



                    }
                }
                if (file.FileName.Contains("hours"))
                {
                    
                }

            }

            return null;
        }
    }
}
