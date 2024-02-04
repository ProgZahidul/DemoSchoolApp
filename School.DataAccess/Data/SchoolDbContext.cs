using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using School.Models.Models;
using static System.Collections.Specialized.BitVector32;

namespace DemoSchoolApp.Models
{
    public class SchoolDbContext : IdentityDbContext
    {
        public DbSet<AcademicMonth> dbsAcademicMonth { get; set; }
        public DbSet<AcademicYear> dbsAcademicYear { get; set; }
        public DbSet<Admission> dbsAdmission { get; set; }
        public DbSet<Attendance> dbsAttendance { get; set; }
        public DbSet<Classes> dbsClasses { get; set; }
        public DbSet<ClassScheduling> dbsClassScheduling { get; set; }
        public DbSet<Employee> dbsEmployee { get; set; }
        public DbSet<EmployeeType> dbsEmployeeType { get; set; }
        public DbSet<Exam> dbsExam { get; set; }
        public DbSet<ExamSchedule> dbsExamSchedule { get; set; }
        public DbSet<ExamType> dbsExamType { get; set; }
        public DbSet<FeePayment> dbsFeePayment { get; set; }
        public DbSet<FeeStructure> dbsFeeStructure { get; set; }
        public DbSet<FeeType> dbsFeeType { get; set; }
        public DbSet<Parent> dbsParent { get; set; }
        public DbSet<Session> dbsSession { get; set; }
        public DbSet<Student> dbsStudent { get; set; }
        public DbSet<Subject> dbsSubject { get; set; }
        



        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }
    }
}
