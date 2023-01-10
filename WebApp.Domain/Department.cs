using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain
{
    public class Department
    {   
        [Key]
        public string Name { get; set; }

        [Required]
        public string PredictionValueName { get; set; }

        [Required]
        public int MinimumAge { get; set; }

        [Required]
        public int StartHourWeekday { get; set; }

        [Required]
        public int EndHourWeekday { get; set; }

        [Required]
        public int StartHourSaturday { get; set; }

        [Required]
        public int EndHourSaturday { get; set; }

        [Required]
        public int StartHourSunday { get; set; }

        [Required]
        public int EndHourSunday { get; set; }
    }
}
