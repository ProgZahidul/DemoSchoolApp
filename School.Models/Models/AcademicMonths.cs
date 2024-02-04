using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoSchoolApp.Models
{
  

    
    public class AcademicMonth
    {
        
        public int AcademicMonthId { get; set; }
        public string MonthName { get; set; }
    }
}