using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBModels.Migrations
{
    /// <inheritdoc />
    public partial class CreatedDeptManagerRelationBetweenInstructorAndDepartmentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dept_Manager",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Dept_Manager",
                table: "Departments",
                column: "Dept_Manager");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Dept_Manager",
                table: "Departments",
                column: "Dept_Manager",
                principalTable: "Instructors",
                principalColumn: "Ins_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Dept_Manager",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Dept_Manager",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Dept_Manager",
                table: "Departments");
        }
    }
}
