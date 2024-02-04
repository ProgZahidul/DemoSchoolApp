using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public string ContactNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime EmployeeDOB { get; set; }
        public int? EmployeeTypeId { get; set; }
        public string? ImagePath { get; set; }

        public virtual EmployeeType? EmployeeType { get; set; }
    }
}
