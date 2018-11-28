using System.ComponentModel.DataAnnotations;

namespace EmployeeControler.Models
{
    public class Worker
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}