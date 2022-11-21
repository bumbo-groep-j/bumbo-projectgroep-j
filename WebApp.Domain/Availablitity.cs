using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class Availability
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee_Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public WeekDays WeekDay { get; set; }

        [NotMapped]
        [RegularExpression("^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "Incorrecte input (HH:MM)")]
        public TimeOnly StartTimes { get; set; }

        [NotMapped]
        [RegularExpression("^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "Incorrecte input (HH:MM)")]
        public TimeOnly EndTimes { get; set; }

        public Availability() { }

    }
}
