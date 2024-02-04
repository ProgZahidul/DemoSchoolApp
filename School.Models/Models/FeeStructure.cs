using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
    [Table("FeeStructures")]
    public class FeeStructure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int FeeStructureId { get; set; }
        public int? ClassId { get; set; }
        public int? FeeTypeId { get; set; }
        public decimal AmountOfFee { get; set; }
        public virtual Classes? Class { get; set; }
        public virtual FeeType? FeeType { get; set; }

    }
}