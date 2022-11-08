using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult LeaveRequests()
        {
            return View();
        }

        public IActionResult Prognosis()
        {
            return View();
        }

        public IActionResult Scheduling()
        {
            return View();
        }

        public IActionResult WorkedHours()
        {
            return View();
        }
    }
}
