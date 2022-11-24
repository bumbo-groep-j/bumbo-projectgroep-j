using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    public class Prognosis
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Value { get; set; }

        [Required]
        [ForeignKey("Department")]
        public string DepartmentName { get; set; }
    }
}
