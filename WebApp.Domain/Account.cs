using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class Account : IdentityUser
    {
        [NotMapped]
        [Required(ErrorMessage = "Het Gebruikersnaam veld is verplicht")]
        [Display(Name = "Gebruikersnaam")]
        public string Username { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Het Wachtwoord veld is verplicht")]
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Het Wachtwoord bevestigen veld is verplicht")]
        [Display(Name = "Wachtwoord bevestigen")]
        [Compare("Password", ErrorMessage = "De wachtwoorden matchen niet")]
        public string PasswordConfirmation { get; set; }
    }
}