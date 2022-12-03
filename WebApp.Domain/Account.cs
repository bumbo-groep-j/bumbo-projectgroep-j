using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class Account : IdentityUser
    {
        [NotMapped]
        [Required]
        [Display(Name = "Gebruikersnaam")]
        public string Username { get; set; }

        [NotMapped]
        [Required]
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [Display(Name = "Wachtwoord bevestigen")]
        [Compare("Password", ErrorMessage = "De wachtwoorden matchen niet")]
        public string PasswordConfirmation { get; set; }
    }
}