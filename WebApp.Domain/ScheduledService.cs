using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class ScheduledService
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee_Id {get; set;}
        public string DivisionName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; } 

    }
}
