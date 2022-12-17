using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain
{
    public class Department
    {   
        [Key]
        public string Name { get; set; }

        [Required]
        public string PredictionValueName { get; set; }

        [Required]
        public int MinimumAge { get; set; }
    }
}
