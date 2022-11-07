using Microsoft.AspNetCore.Mvc;

namespace bumbo_projectgroep_j.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
