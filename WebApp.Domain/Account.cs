using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class Account : IdentityUser
    {
        [NotMapped]
        public string? Password { get; set; }
    }
}