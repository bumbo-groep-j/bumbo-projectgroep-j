﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private SignInManager<Account> signInManager;
        private UserManager<Account> userManager;

        public AccountController(SignInManager<Account> signIn, UserManager<Account> user)
        {
            signInManager = signIn;
            userManager = user;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(Account model)
        {
            model.PasswordConfirmation = model.Password;
            ModelState.Clear();
            TryValidateModel(model);
            if(ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, true, false);

                if(result.Succeeded)
                    return LocalRedirect("~/");
                else
                    ModelState.AddModelError(string.Empty, "Username or password invalid.");
            }

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(Account model)
        {
            if(ModelState.IsValid)
            {
                var result = await userManager.CreateAsync(model, model.Password);

                if(result.Succeeded)
                {
                    await signInManager.PasswordSignInAsync(model.UserName, model.Password, true, false);
                    return LocalRedirect("~/");
                }

                foreach(var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }

            return View();
        }

        [HttpGet]
        [HttpPost]
        public async Task<ActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return LocalRedirect("~/");
        }
    }
}