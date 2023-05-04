using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string Department { get; set; }

        public string DateofJoining { get; set; }

        public string PhotoFileName { get; set; }
    }
}
