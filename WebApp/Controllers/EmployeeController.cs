using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;
using Microsoft.AspNetCore.Authorization;

namespace Bumbo.Controllers
{
    public class EmployeeController : Controller
    {
        private BumboDbContext db;

        public EmployeeController(BumboDbContext dbContext) { db = dbContext; }

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

        [Authorize(Roles = "Employee")]
        public IActionResult Availability()
        {
            if (IsMobile()) return RedirectToAction("Availability", "Mobile");
            return View();
        }

        [Authorize(Roles = "Employee")]
        public IActionResult DeleteRequest(int id)
        {
            var request = db.LeaveRequests.FirstOrDefault(r => r.Id == id);
            if (request != null)
            {
                db.LeaveRequests.Remove(request);
                db.SaveChanges();
            }

            return RedirectToAction("RequestLeave");
        }

        [Authorize(Roles = "Employee")]
        public IActionResult RequestLeave()
        {
            if(IsMobile()) return RedirectToAction("RequestLeave", "Mobile");

            ViewBag.IsEmpty = !db.LeaveRequests.Any();
            ViewBag.Requests = db.LeaveRequests.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
        public IActionResult RequestLeave(LeaveRequest request)
        {
            if (ModelState.IsValid)
            {
                if(request.EndDate < request.StartDate) (request.StartDate, request.EndDate) = (request.EndDate, request.StartDate);

                request.InsertDate = DateTime.Now;

                db.LeaveRequests.Add(request);
                db.SaveChanges();

                return RedirectToAction("RequestLeave");
            }

            return View(request);
        }

        [Authorize(Roles = "Employee")]
        public IActionResult SchoolSchedule()
        {
            if (IsMobile()) return RedirectToAction("SchoolSchedule", "Mobile");
            ViewData["Days"] = listDays();
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