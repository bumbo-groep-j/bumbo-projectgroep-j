using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Prognosis
    {
        [Key]
        public int Id { get; set; }
        public int TotalColli { get; set; }
        public DateTime Date { get; set; }
        public int? TotalCustomers { get; set; }
        [ForeignKey("Division")]
        public string DivisionName { get; set; }
        public Division Division { get; set; }
    }
}
