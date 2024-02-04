﻿// <auto-generated />
using System;
using DemoSchoolApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace School.DataAccess.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20240207192452_addImage")]
    partial class addImage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoSchoolApp.Models.AcademicMonth", b =>
                {
                    b.Property<int>("AcademicMonthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AcademicMonthId"));

                    b.Property<string>("MonthName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AcademicMonthId");

                    b.ToTable("dbsAcademicMonth");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.AcademicYear", b =>
                {
                    b.Property<int>("AcademicYearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AcademicYearId"));

                    b.Property<int>("AcYear")
                        .HasColumnType("int");

                    b.HasKey("AcademicYearId");

                    b.ToTable("AcademicYears");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Admission", b =>
                {
                    b.Property<int>("AdmissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdmissionId"));

                    b.Property<int?>("AcademicYearId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("AdmissionId");

                    b.HasIndex("AcademicYearId");

                    b.HasIndex("StudentId");

                    b.ToTable("Admissions");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Attendance", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceId"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("AttendanceId");

                    b.HasIndex("ClassId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.ClassScheduling", b =>
                {
                    b.Property<int>("ClassSchedulId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassSchedulId"));

                    b.HasKey("ClassSchedulId");

                    b.ToTable("ClassScheduling");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Classes", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"));

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClassSchedulingClassSchedulId")
                        .HasColumnType("int");

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.HasIndex("ClassSchedulingClassSchedulId");

                    b.ToTable("classes");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClassSchedulingClassSchedulId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmployeeDOB")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("ClassSchedulingClassSchedulId");

                    b.HasIndex("EmployeeTypeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.EmployeeType", b =>
                {
                    b.Property<int>("EmployeeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeTypeId"));

                    b.Property<string>("EmployeeTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeTypeId");

                    b.ToTable("EmployeeTypes");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Exam", b =>
                {
                    b.Property<int>("ExamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamID"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<int?>("ExamScheduleId")
                        .HasColumnType("int");

                    b.Property<int?>("ExamTypeID")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int?>("TotalMarks")
                        .HasColumnType("int");

                    b.HasKey("ExamID");

                    b.HasIndex("ClassId");

                    b.HasIndex("ExamScheduleId");

                    b.HasIndex("ExamTypeID");

                    b.HasIndex("SubjectId");

                    b.ToTable("ExamStructures");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.ExamSchedule", b =>
                {
                    b.Property<int>("ExamScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamScheduleId"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ExamScheduleId");

                    b.ToTable("ExamSchedules");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.ExamType", b =>
                {
                    b.Property<int>("ExamTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamTypeID"));

                    b.Property<string>("ExamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExamTypeID");

                    b.ToTable("ExamTypes");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.FeePayment", b =>
                {
                    b.Property<int>("FeePaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeePaymentId"));

                    b.Property<string>("ModeOfPayment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("PaymentDue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPaid")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FeePaymentId");

                    b.HasIndex("StudentId");

                    b.ToTable("FeePayments");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.FeeStructure", b =>
                {
                    b.Property<int>("FeeStructureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeeStructureId"));

                    b.Property<decimal>("AmountOfFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<int?>("FeePaymentId")
                        .HasColumnType("int");

                    b.Property<int?>("FeeTypeId")
                        .HasColumnType("int");

                    b.HasKey("FeeStructureId");

                    b.HasIndex("ClassId");

                    b.HasIndex("FeePaymentId");

                    b.HasIndex("FeeTypeId");

                    b.ToTable("FeeStructures");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.FeeType", b =>
                {
                    b.Property<int>("FeeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeeTypeId"));

                    b.Property<string>("FeeTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeeTypeId");

                    b.ToTable("FeeTypes");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Parent", b =>
                {
                    b.Property<int>("ParentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParentId"));

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParentId");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Session", b =>
                {
                    b.Property<int>("SessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SessionID"));

                    b.Property<int?>("ClassSchedulingClassSchedulId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("SessionDuration")
                        .HasColumnType("time");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("SessionID");

                    b.HasIndex("ClassSchedulingClassSchedulId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AttendanceId")
                        .HasColumnType("int");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("RollNumber")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("AttendanceId");

                    b.HasIndex("ClassId");

                    b.HasIndex("ParentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<int?>("ClassSchedulingClassSchedulId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.HasIndex("ClassSchedulingClassSchedulId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Admission", b =>
                {
                    b.HasOne("DemoSchoolApp.Models.AcademicYear", "AcademicYear")
                        .WithMany()
                        .HasForeignKey("AcademicYearId");

                    b.HasOne("DemoSchoolApp.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.Navigation("AcademicYear");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Attendance", b =>
                {
                    b.HasOne("DemoSchoolApp.Models.Classes", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Classes", b =>
                {
                    b.HasOne("DemoSchoolApp.Models.ClassScheduling", null)
                        .WithMany("Classes")
                        .HasForeignKey("ClassSchedulingClassSchedulId");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Employee", b =>
                {
                    b.HasOne("DemoSchoolApp.Models.ClassScheduling", null)
                        .WithMany("Exams")
                        .HasForeignKey("ClassSchedulingClassSchedulId");

                    b.HasOne("DemoSchoolApp.Models.EmployeeType", "EmployeeType")
                        .WithMany()
                        .HasForeignKey("EmployeeTypeId");

                    b.Navigation("EmployeeType");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Exam", b =>
                {
                    b.HasOne("DemoSchoolApp.Models.Classes", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("DemoSchoolApp.Models.ExamSchedule", null)
                        .WithMany("Exams")
                        .HasForeignKey("ExamScheduleId");

                    b.HasOne("DemoSchoolApp.Models.ExamType", "ExamType")
                        .WithMany()
                        .HasForeignKey("ExamTypeID");

                    b.HasOne("DemoSchoolApp.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("Class");

                    b.Navigation("ExamType");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.FeePayment", b =>
                {
                    b.HasOne("DemoSchoolApp.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.FeeStructure", b =>
                {
                    b.HasOne("DemoSchoolApp.Models.Classes", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("DemoSchoolApp.Models.FeePayment", null)
                        .WithMany("refFeeStructures")
                        .HasForeignKey("FeePaymentId");

                    b.HasOne("DemoSchoolApp.Models.FeeType", "FeeType")
                        .WithMany()
                        .HasForeignKey("FeeTypeId");

                    b.Navigation("Class");

                    b.Navigation("FeeType");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Session", b =>
                {
                    b.HasOne("DemoSchoolApp.Models.ClassScheduling", null)
                        .WithMany("Sessions")
                        .HasForeignKey("ClassSchedulingClassSchedulId");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Student", b =>
                {
                    b.HasOne("DemoSchoolApp.Models.Attendance", null)
                        .WithMany("refStudents")
                        .HasForeignKey("AttendanceId");

                    b.HasOne("DemoSchoolApp.Models.Classes", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("DemoSchoolApp.Models.Parent", "Parents")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Class");

                    b.Navigation("Parents");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Subject", b =>
                {
                    b.HasOne("DemoSchoolApp.Models.ClassScheduling", null)
                        .WithMany("Subjects")
                        .HasForeignKey("ClassSchedulingClassSchedulId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DemoSchoolApp.Models.Attendance", b =>
                {
                    b.Navigation("refStudents");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.ClassScheduling", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Exams");

                    b.Navigation("Sessions");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.ExamSchedule", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("DemoSchoolApp.Models.FeePayment", b =>
                {
                    b.Navigation("refFeeStructures");
                });
#pragma warning restore 612, 618
        }
    }
}
