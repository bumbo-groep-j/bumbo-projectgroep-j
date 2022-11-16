using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Availability()
        {
            return View();
        }

        public IActionResult RequestLeave()
        {
            return View();
        }

        public IActionResult SchoolSchedule()
        {
            return View();
        }

        public IActionResult WorkSchedule()
        {
            return View();
        }
    }
}
