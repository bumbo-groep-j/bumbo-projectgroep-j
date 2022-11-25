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
        [RegularExpression("^(?<firstchar>(?=[A-Za-z]))((?<alphachars>[A-Za-z])|(?<specialchars>[A-Za-z]['-](?=[A-Za-z]))|(?<spaces> (?=[A-Za-z])))*$", 
            ErrorMessage = "Onjuiste invoering")]
        [DisplayName("Voornaam")]
        public string FirstName { get; set; }

        [DisplayName("Tussenvoegsel")]
        public string? MiddleName { get; set; }

        [Required (ErrorMessage = "Dit veld is verplicht")]
        [RegularExpression("^(?<firstchar>(?=[A-Za-z]))((?<alphachars>[A-Za-z])|(?<specialchars>[A-Za-z]['-](?=[A-Za-z]))|(?<spaces> (?=[A-Za-z])))*$",
            ErrorMessage = "Onjuiste invoering")]
        [DisplayName("Achternaam")]
        public string LastName { get; set; }

        [Required (ErrorMessage = "Dit veld is verplicht")]
        [Column(TypeName = "Date")]
        [DisplayName("Geboortedag")]
        public DateTime DateOfBirth { get; set; }

        public string NFCToken { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [RegularExpression ("^[1-9]\\d*$", ErrorMessage = "Onjuiste invoering: alleen cijfers ")]
        [DisplayName("Uurloon")]
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
