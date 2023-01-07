using CsvHelper.Configuration.Attributes;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace WebApp.Domain
{
    public class Employee
    {
        [Key]
        [Ignore]
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
        [Name("BID")]
        [Required(ErrorMessage = "Het NFCToken veld is verplicht")]
        public string NFCToken { get; set; }

        [ForeignKey("Account")]
        [Ignore]
        [DisplayName("Gebruikersnaam")]
        public string UserName { get; set; }

        [Ignore]
        public bool Inactive { get; set; }

        [NotMapped]
        [Ignore]
        public string Name
        {
            get
            {
                return FirstName + " " + (MiddleName != null ? MiddleName + " " : "") + LastName;
            }
        }

        [NotMapped]
        [Ignore]
        public bool OnLeave { get; set; }

        [NotMapped]
        [Ignore]
        public bool CanWork { get; set; }

        [NotMapped]
        [Ignore]
        public int AllowedHoursToday { get; set; }

        [NotMapped]
        [Ignore]
        public int AllowedHoursWeek { get; set; }

        [NotMapped]
        [Ignore]
        public int AllowedHours4Weeks { get; set; }
    }
}
