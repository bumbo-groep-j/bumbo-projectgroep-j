using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
