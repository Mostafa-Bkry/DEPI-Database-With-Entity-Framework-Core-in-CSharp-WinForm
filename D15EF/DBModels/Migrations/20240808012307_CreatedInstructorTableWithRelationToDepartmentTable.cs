using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBModels.Migrations
{
    /// <inheritdoc />
    public partial class CreatedInstructorTableWithRelationToDepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Ins_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ins_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ins_Degree = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    Dept_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Ins_Id);
                    table.ForeignKey(
                        name: "FK_Instructor_Departments_Dept_Id",
                        column: x => x.Dept_Id,
                        principalTable: "Departments",
                        principalColumn: "Dept_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Dept_Id",
                table: "Instructor",
                column: "Dept_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructor");
        }
    }
}
