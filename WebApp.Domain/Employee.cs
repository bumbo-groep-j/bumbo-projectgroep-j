using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string? MiddelName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Birthdate { get; set; }
        public string NFCToken { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public double HourSalary { get; set; } 
    }
}
