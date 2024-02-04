using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
    [Table("AcademicYears")]
    public class AcademicYear
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AcademicYearId { get; set; }
        [Range(2000, 2099, ErrorMessage = "AcYear must be between 2000 and 2099")]
        public int AcYear { get; set; }

    }
}