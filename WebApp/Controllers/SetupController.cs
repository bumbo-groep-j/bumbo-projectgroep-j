using Bumbo.Models;
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
            return db.Users.Count() == 0 ||
            (
                from UserRole
                in db.UserRoles
                where UserRole.RoleId == (
                    from Role
                    in db.Roles
                    where Role.Name == "Manager"
                    select Role.Id
                ).First()
                select UserRole
            ).Count() == 0;
        }

        public IActionResult Index()
        {
            if(!CanRunSetup()) return LocalRedirect("~/");

            ViewBag.Guid = Guid.NewGuid().ToString();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(EmployeeAccount model)
        {
            if(!CanRunSetup()) return LocalRedirect("~/");

            model.Employee.UserName = model.Account.Username;
            model.Employee.Role = model.Role;
            model.Account.UserName = model.Account.Username;
            ModelState.Clear();
            TryValidateModel(model);
            try
            {
                if(ModelState.IsValid)
                {
                    var result = await userManager.CreateAsync(model.Account, model.Account.Password);

                    if(result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(model.Account, model.Role);

                        db.Employees.Add(model.Employee);
                        db.SaveChanges();

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
