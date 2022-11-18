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

        public List<string> listDays()
        {
            List<string> listOfDays = new List<string>();
            listOfDays.Add("Maandag");
            listOfDays.Add("Dinsdag");
            listOfDays.Add("Woensdag");
            listOfDays.Add("Donderdag");
            listOfDays.Add("Vrijdag");
            listOfDays.Add("Zaterdag");
            listOfDays.Add("Zondag");

            return listOfDays;
        }



        public IActionResult WorkSchedule()
        {
            //Get the current day
            /*var dt = DateTime.Now;
            //Get first and last day of the week
            int begin = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
            int end = (7 + (DayOfWeek.Sunday - dt.DayOfWeek)) % 7;
            
            DateTime beginTime = dt.AddDays(-1 * begin).Date;
            DateTime endTime = dt.AddDays(end).Date;
            ViewBag.StartDate = beginTime;
            ViewBag.EndDate = endTime;*/
            ViewData["Days"] = listDays();

            return View();
        }  
        
       
    }
}
