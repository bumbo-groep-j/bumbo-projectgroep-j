using Bumbo.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class EmployeeController : Controller
    {
        private bool IsMobile()
        {
            var userAgent = Request.Headers["User-Agent"].ToString().ToLower();

            if(userAgent == null) return false;

            return userAgent.Contains("blackberry")
                || userAgent.Contains("webos")
                || userAgent.Contains("iphone")
                || userAgent.Contains("iemobile")
                || userAgent.Contains("android")
                || userAgent.Contains("windows phone")
                || userAgent.Contains("ipad")
                || userAgent.Contains("ipod");
        }
        public IActionResult Availability()
        {
            if(IsMobile()) return RedirectToAction("Availability", "Mobile");
            return View();
        }

        public IActionResult RequestLeave()
        {
            if(IsMobile()) return RedirectToAction("RequestLeave", "Mobile");
            return View();
        }

        public IActionResult SchoolSchedule()
        {
            if(IsMobile()) return RedirectToAction("SchoolSchedule", "Mobile");
            return View();
        }

        public IActionResult WorkSchedule()
        {
            if(IsMobile()) return RedirectToAction("WorkSchedule", "Mobile");
            return View();
        }
        public IActionResult Index()
        {
            return RedirectToAction("WorkSchedule");
        }
    }
}