using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    public class EmployeeController : Controller
    {
        private BumboDbContext db;
        private UserManager<Account> userManager;

        public EmployeeController(BumboDbContext dbContext, UserManager<Account> user) { db = dbContext; userManager = user; }

        private bool IsMobile() {
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

        private DateTime ParseDate(int year, int month, int day, DateTime defaultDate)
        {
            try
            {
                return new DateTime(year, month, day);
            }
            catch(Exception)
            {
                return defaultDate;
            }
        }

        private IActionResult LoadPage<MobileModelType, DesktopModelType>(MobileModelType mobileModel, DesktopModelType desktopModel, [CallerMemberName] string caller = "")
        {
            if(IsMobile()) {
                ViewBag.IsMobile = true;
                return View(caller + "Mobile", mobileModel);
            } else return View(caller + "Desktop", desktopModel);
        }

        private IActionResult LoadPage<ModelType>(ModelType model, [CallerMemberName] string caller = "")
        {
            return LoadPage(model, model, caller);
        }

        private IActionResult LoadPage([CallerMemberName] string caller = "") {
            if(IsMobile()) {
                ViewBag.IsMobile = true;
                return View(caller + "Mobile");
            } else return View(caller + "Desktop");
        }

        [Authorize(Roles = "Employee")]
        public IActionResult WorkSchedule(int year, int month, int day, bool fullSize)
        {
            DateTime date = ParseDate(year, month, day, DateTime.Today);

            date = date.AddDays(1 - (int)date.DayOfWeek);

            ViewBag.Date = date;
            ViewBag.FullSize = fullSize;

            return LoadPage((
                from Schedule in db.Schedules
                join Employee in db.Employees
                on Schedule.EmployeeId equals Employee.Id
                where Employee.UserName == userManager.GetUserName(User) && Schedule.StartTime.Date >= date && Schedule.EndTime.Date < date.AddDays(7)
                select Schedule
            ).ToList().OrderBy(schedule => schedule.StartTime));
        }
    }
}
