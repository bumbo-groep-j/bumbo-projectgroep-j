using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain
{
    public class CAOBonuses
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime ValidSince { get; set; }

        [Required]
        public double HolidayBonus { get; set; }

        [Required]
        public double SundayBonus { get; set; }
    }
}
