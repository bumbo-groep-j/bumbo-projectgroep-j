using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class Schedule
    {
        [Key]
        [Ignore]
        public int Id { get; set; }

        [ForeignKey("Employee")]
        [Ignore]
        public int EmployeeId { get; set; }
        [Ignore]
        public Employee Employee { get; set; }

        [Required]
        [ForeignKey("Department")]
        [Name("Afdeling")]
        public string Department { get; set; }

        [Required]
        [Name("Clock in")]
        public DateTime StartTime { get; set; }

        [Required]
        [Name("Clock out")]
        public DateTime EndTime { get; set; }

        [NotMapped]
        [Name("BID")]
        public string BID { get; set; }

        [NotMapped]
        [Name("Date")]
        public DateTime Date { get; set; }

        [Required]
        [Ignore]
        public bool SickLeave { get; set; }
    }
}
