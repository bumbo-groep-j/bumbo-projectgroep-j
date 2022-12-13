using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain
{
    public class LeaveRequest
    {
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        public DateTime EndDate { get; set; }

        public string? Comment { get; set; }

        public DateTime InsertDate { get; set; }

        public bool Approved { get; set; }

        public bool Rejected { get; set; }
    }
}