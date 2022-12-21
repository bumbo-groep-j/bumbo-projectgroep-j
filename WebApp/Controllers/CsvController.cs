using CsvHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.IO.Pipelines;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    public class CsvController : Controller
    {
        // GET: CsvController
        private CsvReader csvReader;
        private List<Employee> csvEmployees;
        private List<WorkedHour> csvHours;
        private List<Schedule> csvSchedules;
        private List<Account> csvAccounts;

        public CsvController()
        {
            //TODO files uitlezen.
        }

        [Authorize(Roles = "Manager")]
        public ActionResult CsvImport()
        {
            return View();
        }
        [HttpPost]
        public Task<ActionResult> ReadFromCSV(IFormCollection collection)
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
