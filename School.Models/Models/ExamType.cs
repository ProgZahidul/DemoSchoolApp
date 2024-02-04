using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{

    [Table("ExamTypes")]
    public class ExamType

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamTypeID { get; set; }
        public string ExamName { get; set; }

    }
}
