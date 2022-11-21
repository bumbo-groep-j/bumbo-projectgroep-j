using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Domain
{
    public class WorkedHour
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        [Required]
        [ForeignKey("Department")]
        public string Department { get; set; }
        [Required]
        public DateTime ApprovalTime { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
    }
}
