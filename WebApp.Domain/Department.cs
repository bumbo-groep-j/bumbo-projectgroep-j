using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain
{
    public class Department
    {   
        [Key]
        public string Name { get; set; }
    }
}
