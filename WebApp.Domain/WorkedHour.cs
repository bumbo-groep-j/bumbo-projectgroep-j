using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class WorkedHour
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Required]
        [ForeignKey("Department")]
        public string Department { get; set; }

        [Required]
        public DateTime ApprovalTime { get; set; }

        [Required]
        public DateTime ClockedTimeStart { get; set; }

        public DateTime? ClockedTimeEnd { get; set; }

        public DateTime? ApprovedTimeStart { get; set; }

        public DateTime? ApprovedTimeEnd { get; set; }
    }
}
