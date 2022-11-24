using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }

        public string NFCToken { get; set; }

        [Required]
        public double HourlyWage { get; set; }

        [NotMapped]
        public string Name 
        {
            get
            {
                return FirstName + " " + (MiddleName != null ? MiddleName + " " : "") + LastName;
            }
        }
    }
}
