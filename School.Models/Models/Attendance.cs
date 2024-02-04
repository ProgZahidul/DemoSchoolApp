using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
    [Table("Attendances")]
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceId { get; set; }
        public int ClassId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public virtual ICollection<Student> refStudents { get; set; }=new List<Student>();
        public virtual Classes Class { get; set; }
        
    }
}