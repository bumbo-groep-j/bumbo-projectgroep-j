using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class LoginController : Controller
    {

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // Check if username and password are correct
        [HttpPost]
        public ActionResult Login(WebApp.Domain.Account model)
        {
            // microsoft authenticator????????????
            return View();
        }
    }
}
