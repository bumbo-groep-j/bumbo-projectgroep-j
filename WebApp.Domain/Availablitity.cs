using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    public class Availability
    {

        [RegularExpression("^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "Incorrecte input (HH:MM)")]
        public TimeOnly StartTime { get; set; }

        [RegularExpression("^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "Incorrecte input (HH:MM)")]
        public TimeOnly EndTime { get; set; }

        public Availability() { }

    }
}
