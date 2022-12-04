using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

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

        [Authorize(Roles = "Employee")]
        public IActionResult Availability()
        {
            if(IsMobile()) return RedirectToAction("Availability", "Mobile");
            return View();
        }

        [Authorize(Roles = "Employee")]
        public IActionResult RequestLeave()
        {
            if(IsMobile()) return RedirectToAction("RequestLeave", "Mobile");
            return View();
        }

        [Authorize(Roles = "Employee")]
        public IActionResult SchoolSchedule()
        {
            ViewData["Days"] = listDays();
            if (IsMobile()) return RedirectToAction("SchoolSchedule", "Mobile");
            return View();
        }

        [Authorize(Roles = "Employee")]
        public List<string> listDays()
        {
            List<string> listOfDays = new List<string>();
            listOfDays.Add("Maandag");
            listOfDays.Add("Dinsdag");
            listOfDays.Add("Woensdag");
            listOfDays.Add("Donderdag");
            listOfDays.Add("Vrijdag");
            listOfDays.Add("Zaterdag");
            listOfDays.Add("Zondag");

            return listOfDays;
        }

        [Authorize(Roles = "Employee")]
        public IActionResult WorkSchedule()
        {

            //Get the current day
            /*var dt = DateTime.Now;
            //Get first and last day of the week
            int begin = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
            int end = (7 + (DayOfWeek.Sunday - dt.DayOfWeek)) % 7;
            
            DateTime beginTime = dt.AddDays(-1 * begin).Date;
            DateTime endTime = dt.AddDays(end).Date;
            ViewBag.StartDate = beginTime;
            ViewBag.EndDate = endTime;
            ViewBag.EndDate = endTime;*/
            if (IsMobile()) return RedirectToAction("WorkSchedule", "Mobile");
            ViewData["Days"] = listDays();

            return View();
        }

        [Authorize(Roles = "Employee")]
        public IActionResult Index()
        {
            return RedirectToAction("WorkSchedule");
        }
    }
}