using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
    [Table("Parents")]
    public class Parent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParentId { get; set; }
        public string ParentName { get; set; }
        public string ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Profession {  get; set; }
        public string? ImagePath { get; set; }

    }
}