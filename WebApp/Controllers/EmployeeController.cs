using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Bumbo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Availability()
        {
            return View();
        }

        public IActionResult RequestLeave()
        {
            return View();
        }

        public IActionResult SchoolSchedule()
        {
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
     
            return View();
        }  
        
       
    }
}
