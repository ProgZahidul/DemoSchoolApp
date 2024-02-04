using DemoSchoolApp.Models;

namespace DemoSchoolApp.ImageModels
{
    public class EmployeeImg:Employee
    {
        public IFormFile? file { get; set; }
    }
}
