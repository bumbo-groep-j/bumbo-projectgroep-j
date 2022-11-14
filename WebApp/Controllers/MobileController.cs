using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class MobileController : Controller
    {
        public IActionResult Availability()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult RequestLeave()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult SchoolSchedule()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult WorkSchedule()
        {
            ViewBag.IsMobile = true;
            return View();
        }

        public IActionResult Index()
        {
            return RedirectToAction("WorkSchedule");
        }
    }
}