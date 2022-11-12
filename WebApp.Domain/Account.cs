using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain
{
    public class Account
    {
        public int UserID { get; set; }
        
        [Required(ErrorMessage = "This field is required")]
        public string Username { get; set; }

        [DataType(DataType.Password)]  // Changes the input from normal characters to dots
        [RegularExpression ("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]){8,}$")]  // checks if there are a minimum of 8 characters consisting of at least 1 Capital letter and 1 Number
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; } // Public for now for the database generation

        public Account() { }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}