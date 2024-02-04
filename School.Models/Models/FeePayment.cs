using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
    [Table("FeePayments")]
    public class FeePayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeePaymentId { get; set; }

        public int? StudentId { get; set; }
       
        public virtual Student Student { get; set; }

        public virtual List<FeeStructure> refFeeStructures { get; set; } = new List<FeeStructure>();

        [NotMapped] // This property won't be mapped to the database
        public decimal TotalFee
        {
            get
            {
                return refFeeStructures.Sum(feeStructure => feeStructure.AmountOfFee);
            }
        }

        public decimal TotalPaid { get; set; }
        public string? ModeOfPayment { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal? PaymentDue { get; set; }
    }
}