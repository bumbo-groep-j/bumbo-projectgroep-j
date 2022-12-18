using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain
{
    public class CAORegulation
    {
        [Key]
        public int Age { get; set; }

        [Required]
        public int AllowedHoursSchoolDay { get; set; }

        [Required]
        public int AllowedHoursSchoolWeek { get; set; }

        [Required]
        public int AllowedHoursNotSchoolDay { get; set; }

        [Required]
        public int AllowedHoursNotSchoolWeek { get; set; }

        [Required]
        public int AllowedHours4Weeks { get; set; }
    }
}
