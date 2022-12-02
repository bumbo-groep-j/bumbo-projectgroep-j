using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class Prognosis
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "het veld is leeg")]
        public int TotalColli { get; set; }


        [Required(ErrorMessage = "het veld is leeg")]
        public DateTime Date { get; set; }

        
        [Required(ErrorMessage = "het veld is leeg")]
        public int TotalCustomers { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Value { get; set; }



        [Required(ErrorMessage = "het veld is leeg")]
        [ForeignKey("Department")]
        public string DepartmentName { get; set; }
    }
}
