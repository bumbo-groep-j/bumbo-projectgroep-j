using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    [AllowAnonymous]
    public class SetupController : Controller
    {
        private UserManager<Account> userManager;
        private SignInManager<Account> signInManager;
        private BumboDbContext db;

        public SetupController(UserManager<Account> user, SignInManager<Account> signIn, BumboDbContext dbContext)
        {
            userManager = user;
            signInManager = signIn;
            db = dbContext;
        }

        private bool CanRunSetup()
        {
            return db.Users.Count() == 0;
        }

        public IActionResult Index()
        {
            if(!CanRunSetup()) return LocalRedirect("~/");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Account model)
        {
            if(!CanRunSetup()) return LocalRedirect("~/");

            model.UserName = model.Username;
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await userManager.CreateAsync(model, model.Password);

                    if(result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(model, "Manager");
                        await signInManager.PasswordSignInAsync(model.UserName, model.Password, true, false);

                        return RedirectToAction("ListEmployees", "Manager");
                    }

                    foreach(var error in result.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            catch { }

            return View(model);
        }
    }
}
