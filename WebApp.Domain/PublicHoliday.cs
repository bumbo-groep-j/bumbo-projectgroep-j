using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain
{
    public class PublicHoliday
    {
        [Key]
        public DateTime Date { get; set; }
    }
}
