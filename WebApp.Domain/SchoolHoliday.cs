using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain
{
    public class SchoolHoliday
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}