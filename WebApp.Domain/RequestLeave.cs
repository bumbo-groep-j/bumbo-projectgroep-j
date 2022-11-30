using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    public class RequestLeave
    {
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Key]
        public int Id { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Dit veld is verplicht")]
        public DateOnly StartDate { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Dit veld is verplicht")]
        public DateOnly EndDate { get; set; }
        public string Comment { get; set; }

    }
}