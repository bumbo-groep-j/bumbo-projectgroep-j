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

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        public DateTime EndDate { get; set; }
        
        public string? Comment { get; set; }

        public bool Approved { get; set; }

    }
}