using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_classes_ClasssesClassId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClasssesClassId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClasssesClassId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Parents",
                newName: "ContactNumber");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_classes_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "classes",
                principalColumn: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_classes_ClassId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "Parents",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<int>(
                name: "ClasssesClassId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClasssesClassId",
                table: "Students",
                column: "ClasssesClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_classes_ClasssesClassId",
                table: "Students",
                column: "ClasssesClassId",
                principalTable: "classes",
                principalColumn: "ClassId");
        }
    }
}
