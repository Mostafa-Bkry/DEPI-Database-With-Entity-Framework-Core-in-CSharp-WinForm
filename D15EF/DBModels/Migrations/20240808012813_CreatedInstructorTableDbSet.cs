using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBModels.Migrations
{
    /// <inheritdoc />
    public partial class CreatedInstructorTableDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Departments_Dept_Id",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_Dept_Id",
                table: "Instructors",
                newName: "IX_Instructors_Dept_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Dept_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_Dept_Id",
                table: "Instructor",
                newName: "IX_Instructor_Dept_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Departments_Dept_Id",
                table: "Instructor",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Dept_Id");
        }
    }
}
