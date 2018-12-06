using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeControler.Models
{
    public class NewTask
    {
        public int Id { get; set; }

        [Required]
        public string TaskName { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public Worker Worker { get; set; }
    }

}