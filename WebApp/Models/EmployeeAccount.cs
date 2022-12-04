using System.ComponentModel.DataAnnotations;
using WebApp.Domain;

namespace Bumbo.Models {
    public class EmployeeAccount {
        public Employee? Employee { get; set; }
        public Account Account { get; set; }

        [Display(Name = "Rol")]
        public string Role { get; set; }
    }
}
