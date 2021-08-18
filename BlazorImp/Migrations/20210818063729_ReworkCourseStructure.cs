using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorImp.Migrations
{
    public partial class ReworkCourseStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseElements");

            migrationBuilder.DropTable(
                name: "CourseElementSequences");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "StepNumber",
                table: "Pages");

            migrationBuilder.AddColumn<int>(
                name: "CourseSequenceID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CourseSequenceElements",
                columns: table => new
                {
                    CourseSequenceElementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentCourseSequenceID = table.Column<int>(type: "int", nullable: false),
                    ElementIndex = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PageID = table.Column<int>(type: "int", nullable: true),
                    CourseSequenceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSequenceElements", x => x.CourseSequenceElementID);
                });

            migrationBuilder.CreateTable(
                name: "CourseSequences",
                columns: table => new
                {
                    CourseSequenceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSequences", x => x.CourseSequenceID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseSequenceElements");

            migrationBuilder.DropTable(
                name: "CourseSequences");

            migrationBuilder.DropColumn(
                name: "CourseSequenceID",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StepNumber",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CourseElements",
                columns: table => new
                {
                    CourseElementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseElementSequenceID = table.Column<int>(type: "int", nullable: true),
                    PageID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseElements", x => x.CourseElementID);
                });

            migrationBuilder.CreateTable(
                name: "CourseElementSequences",
                columns: table => new
                {
                    CourseElementSequenceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseElementID = table.Column<int>(type: "int", nullable: false),
                    ElementIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseElementSequences", x => x.CourseElementSequenceID);
                });
        }
    }
}
