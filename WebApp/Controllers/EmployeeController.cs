using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Bumbo.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace Bumbo.Controllers
{
    public class EmployeeController : Controller
    {
        private bool IsMobile()
        {
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
        public IActionResult Availability()
        {
            if(IsMobile()) return RedirectToAction("Availability", "Mobile");
            return View();
        }

        public IActionResult RequestLeave()
        {
            if(IsMobile()) return RedirectToAction("RequestLeave", "Mobile");
            return View();
        }

        public IActionResult SchoolSchedule()
        {
            if(IsMobile()) return RedirectToAction("SchoolSchedule", "Mobile");
            return View();
        }

        public IActionResult WorkSchedule()
        {

            //Get the current day
            var dt = DateTime.Now;
            var currentDay = dt.DayOfWeek;

            //Get first and last day of the week
            int begin = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
            int end = (7 + (DayOfWeek.Sunday - dt.DayOfWeek)) % 7;

            //Convert it to an integer
            int days  = (int)currentDay -1;
            //Subtract that many days from the current date.That gives you the date for Sunday.
            //Create a list, starting with Sunday.
            DateTime sunday = dt.AddDays(-days);
            ViewBag.DaysThisWeek = Enumerable.Range(0, 7)
                .Select(d => sunday.AddDays(d)) .ToList();

            DateTime beginTime = dt.AddDays(-1 * begin).Date;
            DateTime endTime = dt.AddDays(end).Date;
            ViewBag.StartDate = beginTime;
            ViewBag.EndDate = endTime;
     
            if(IsMobile()) return RedirectToAction("WorkSchedule", "Mobile");
            return View();
        }
        public IActionResult Index()
        {
            return RedirectToAction("WorkSchedule");
        }

    }
}