using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    [PrimaryKey("Date", "DepartmentName")]
    public class DataPoint
    {
        [Key]
        public DateTime Date { get; set; }

        [Key]
        [ForeignKey("DataSet")]
        public string DepartmentName { get; set; }

        [Required]
        public bool IsHoliday { get; set; }

        [Required]
        public int Value { get; set; }
    }
}
