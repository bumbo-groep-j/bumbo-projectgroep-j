using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
