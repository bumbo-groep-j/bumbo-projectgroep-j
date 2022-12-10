using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    [PrimaryKey("EmployeeId", "Weekday", "Id")]
    public class Availability
    {
        [Key]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [Key]
        public Weekday Weekday { get; set; }

        [Key]
        public int Id { get; set; }

        public Employee Employee { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime? EndDate { get; set; }
    }
}
