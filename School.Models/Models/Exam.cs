using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
    [Table("ExamStructures")]
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamID { get; set; }
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }
        public int? ExamTypeID { get; set; }
        public int? TotalMarks { get; set; }
        public virtual Classes? Class { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual ExamType? ExamType { get; set; }
    }
}
