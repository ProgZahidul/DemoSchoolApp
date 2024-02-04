using DemoSchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models.Models
{
    public class StudentBalance
    {
        public int StudentBalanceId { get; set; }
        public int StudentId { get; set; }
        public int AcademicMonthId { get; set; }
        public decimal TotalPymentDue { get; set; }
        public virtual AcademicMonth? AcademicMonth { get; set; }
        public virtual Student? Student { get; set; }
        

    }
}
