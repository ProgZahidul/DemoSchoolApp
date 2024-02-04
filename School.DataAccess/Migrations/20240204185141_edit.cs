using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeTypes_EmployeeTypeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_FeePayments_Students_StudentId",
                table: "FeePayments");

            migrationBuilder.DropForeignKey(
                name: "FK_FeeStructures_FeeTypes_FeeTypeId",
                table: "FeeStructures");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_classes_ClasssesClassId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "ClasssesClassId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FeeTypeId",
                table: "FeeStructures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "FeePayments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeTypeId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeTypes_EmployeeTypeId",
                table: "Employees",
                column: "EmployeeTypeId",
                principalTable: "EmployeeTypes",
                principalColumn: "EmployeeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeePayments_Students_StudentId",
                table: "FeePayments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeeStructures_FeeTypes_FeeTypeId",
                table: "FeeStructures",
                column: "FeeTypeId",
                principalTable: "FeeTypes",
                principalColumn: "FeeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_classes_ClasssesClassId",
                table: "Students",
                column: "ClasssesClassId",
                principalTable: "classes",
                principalColumn: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeTypes_EmployeeTypeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_FeePayments_Students_StudentId",
                table: "FeePayments");

            migrationBuilder.DropForeignKey(
                name: "FK_FeeStructures_FeeTypes_FeeTypeId",
                table: "FeeStructures");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_classes_ClasssesClassId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "ClasssesClassId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FeeTypeId",
                table: "FeeStructures",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "FeePayments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeTypeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeTypes_EmployeeTypeId",
                table: "Employees",
                column: "EmployeeTypeId",
                principalTable: "EmployeeTypes",
                principalColumn: "EmployeeTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeePayments_Students_StudentId",
                table: "FeePayments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeeStructures_FeeTypes_FeeTypeId",
                table: "FeeStructures",
                column: "FeeTypeId",
                principalTable: "FeeTypes",
                principalColumn: "FeeTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_classes_ClasssesClassId",
                table: "Students",
                column: "ClasssesClassId",
                principalTable: "classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
