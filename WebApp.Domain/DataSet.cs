using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class DataSet
    {
        [Key]
        [ForeignKey("Department")]
        public string DepartmentName { get; set; }

        [Required]
        public int MinimumEmployees { get; set; }

        [Required]
        public int DepartmentStartHour { get; set; }

        [Required]
        public int DepartmentEndHour { get; set; }

        [Required]
        public int EmployeeWorkLoad { get; set; }

        [Required]
        public List<HourlyPoint> HourlyCurve { get; set; }

        [NotMapped]
        private double[] WeeklyCurve { get; set; }

        [NotMapped]
        private double[] MonthlyCurve { get; set; }

        [NotMapped]
        private double HolidayFactor { get; set; }

        [NotMapped]
        private int YearlyTotal { get; set; }
    }
}
