using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
    [Table("ExamSchedules")]
    public class ExamSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamScheduleId { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }
        [DataType(DataType.Time)]
        public DateTime? StartTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime? EndTime { get; set; }
        public string? Comment { get; set; }
        public virtual List<Exam> Exams { get; set; } = new List<Exam>();

    }
}
