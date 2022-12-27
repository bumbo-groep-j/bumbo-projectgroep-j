using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private BumboDbContext db;
        private SignInManager<Account> signInManager;

        public AccountController(SignInManager<Account> manager, BumboDbContext dbContext)
        {
            signInManager = manager;
            db = dbContext;
        }

        public ActionResult Login()
        {
            if(db.Users.Count() == 0) return RedirectToAction("Index", "Setup");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(Account model)
        {
            if(db.Users.Count() == 0) return RedirectToAction("Index", "Setup");

            model.PasswordConfirmation = model.Password;
            ModelState.Clear();
            TryValidateModel(model);

            if(ModelState.IsValid)
            {
                if((from Employee in db.Employees where Employee.UserName == model.UserName && Employee.Inactive select Employee).Any())
                {
                    ModelState.AddModelError(string.Empty, "Deze medewerker is inactief.");
                    return View();
                }

                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, true, false);

                if(result.Succeeded)
                    return LocalRedirect("~/");
                else
                    ModelState.AddModelError(string.Empty, "Gebruikersnaam of wachtwoord onjuist.");
            }

            return View();
        }

        public async Task<ActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return LocalRedirect("~/");
        }

        public ActionResult AccessDenied()
        {
            return RedirectToAction("Login");
        }
    }
}