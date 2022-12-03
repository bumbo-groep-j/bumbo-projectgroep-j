using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Voornaam")]
        public string FirstName { get; set; }

        [DisplayName("Tussenvoegsel")]
        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Achternaam")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [Column(TypeName = "Date")]
        [DisplayName("Geboortedag")]
        public DateTime DateOfBirth { get; set; }

        public string NFCToken { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [DisplayName("Uurloon")]
        public double HourlyWage { get; set; }

        [ForeignKey("Account")]
        [DisplayName("Gebruikersnaam")]
        public string UserName { get; set; }

        public bool Inactive { get; set; }

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
