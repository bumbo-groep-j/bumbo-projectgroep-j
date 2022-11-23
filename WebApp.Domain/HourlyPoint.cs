using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain
{
    [PrimaryKey("DepartmentName", "Hour")]
    public class HourlyPoint
    {
        [Key]
        [ForeignKey("DataSet")]
        public string DepartmentName { get; set; }

        [Key]
        public int Hour { get; set; }

        [Required]
        public double Value { get; set; }
    }
}