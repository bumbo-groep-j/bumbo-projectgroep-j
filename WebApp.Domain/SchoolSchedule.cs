using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Domain
{
    public class SchoolSchedule
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set;}
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public WeekDays WeekDay { get; set; }
    }
}
