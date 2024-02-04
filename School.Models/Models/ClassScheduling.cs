using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoSchoolApp.Models
{
    [Table("ClassScheduling")]
    public class ClassScheduling
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassSchedulId { get; set; }

        public virtual List<Session> Sessions { get; set; } = new List<Session>();
        public virtual List<Classes> Classes { get; set; } = new List<Classes>();
        public virtual List<Subject> Subjects { get; set; } = new List<Subject>();
        public virtual List<Employee> Exams { get; set; } = new List<Employee>();


    }
}
