using CsvHelper.Configuration.Attributes;
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

        [Required(ErrorMessage = "Het Voornaam veld is verplicht")]
        [DisplayName("Voornaam")]
        [Name("Vn")]
        public string FirstName { get; set; }
        [Name("Tv")]
        [DisplayName("Tussenvoegsel")]
        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Het Achternaam veld is verplicht")]
        [Name("An")]
        [DisplayName("Achternaam")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Het Geboortedatum veld is verplicht")]
        [Column(TypeName = "Date")]
        [Name("Geboortedatum")]
        [DisplayName("Geboortedatum")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("NFC-Token")]
        [Required(ErrorMessage = "Het NFCToken veld is verplicht")]
        public string NFCToken { get; set; }
        
        /*[Required(ErrorMessage = "Het Uurloon veld is verplicht")]
        [DisplayName("Uurloon")]
        [Range(0.01, Double.MaxValue, ErrorMessage = "Het Uurloon moet meer dan 0 zijn")]
        public double HourlyWage { get; set; }
        */

        [ForeignKey("Account")]
        [DisplayName("Gebruikersnaam")]
        public string UserName { get; set; }

        public bool Inactive { get; set; }

        [NotMapped]
        public Department Department { get; set; }

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
