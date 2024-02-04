using DemoSchoolApp.Models;

namespace DemoSchoolApp.ImageModels
{
    public class StudentImg:Student
    {
        public IFormFile? file { get; set; }
    }
}
