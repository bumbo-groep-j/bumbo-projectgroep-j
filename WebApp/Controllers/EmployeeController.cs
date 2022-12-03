using Bumbo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;
using System.Web;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    public class EmployeeController : Controller
    {

        private bool IsMobile()
        {
            var userAgent = Request.Headers["User-Agent"].ToString().ToLower();

            if (userAgent == null) return false;

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
            if (IsMobile()) return RedirectToAction("Availability", "Mobile");
            return View();
        }

        public IActionResult DeleteRequest(int id)
        {
            // delete request
            using (var context = new BumboDbContext())
            {
                var request = context.Requests.FirstOrDefault(r => r.Id == id);
                if (request != null)
                {
                    context.Requests.Remove(request);
                    context.SaveChanges();
                }
            }
            return RedirectToAction("RequestLeave");
        }

        public IActionResult RequestLeave()
        {
            using (var context = new BumboDbContext())
            {
                bool isEmpty = false;

                if (!context.Requests.Any())
                {
                    isEmpty = true;
                    ViewBag.isEmpty = isEmpty;
                } else
                {
                    isEmpty = false;
                    ViewBag.isEmpty = isEmpty;
                }

                ViewBag.Requests = context.Requests.ToList();
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RequestLeave(RequestLeave request)
        {
            if (IsMobile()) return RedirectToAction("RequestLeave", "Mobile");

            if (ModelState.IsValid)
            {
                using (var context = new BumboDbContext())
                {
                    //ViewBag.Requests = context.Requests.ToList
                    context.Requests.Add(request);
                    context.SaveChanges();
                }
                return RedirectToAction("RequestLeave");
            }
            return View(request);
        }

        public IActionResult SchoolSchedule()
        {
            ViewData["Days"] = listDays();
            if (IsMobile()) return RedirectToAction("SchoolSchedule", "Mobile");
            return View();
        }

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
        public IActionResult Index()
        {
            return RedirectToAction("WorkSchedule");
        }

    }
}