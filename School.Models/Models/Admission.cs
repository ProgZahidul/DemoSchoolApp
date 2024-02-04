using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
    [Table("Admissions")]
    public class Admission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdmissionId { get; set; }
        public int? StudentId { get; set; }
        public int? AcademicYearId { get; set; }
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }
        public string? UpdatedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? UpdatedOn { get; set; }
        public virtual Student? Student { get; set; }
        public virtual AcademicYear? AcademicYear { get; set; }
    }
}
