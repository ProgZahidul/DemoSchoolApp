using static System.Collections.Specialized.BitVector32;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int RollNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int? ClassId { get; set; }
        public int? ParentId { get; set; }
        public string? ImagePath { get; set; }
        public virtual Parent? Parents { get; set; }
        public virtual Classes? Class { get; set; }
    }
}
