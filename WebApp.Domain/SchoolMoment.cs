using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class SchoolMoment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set;}
        public Employee Employee_Id { get; set; }

        public int? TotalHour { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? date { get; set; }
    }
}
