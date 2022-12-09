﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bumbo.Models;
using Microsoft.AspNetCore.Authorization;

namespace Bumbo.Controllers;

public class HomeController : Controller
{
    [Authorize(Roles = "Manager, Employee")]
    public IActionResult Index()
    {
        return View();
    }

    [Authorize(Roles = "Manager, Employee")]
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

