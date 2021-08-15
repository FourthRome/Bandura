using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorImp.Migrations
{
    public partial class ComplexCourseStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseElements",
                columns: table => new
                {
                    CourseElementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PageID = table.Column<int>(type: "int", nullable: true),
                    CourseElementSequenceID = table.Column<int>(type: "int", nullable: true)
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
                    ElementIndex = table.Column<int>(type: "int", nullable: false),
                    CourseElementID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseElementSequences", x => x.CourseElementSequenceID);
                });

            migrationBuilder.CreateTable(
                name: "PageStats",
                columns: table => new
                {
                    PageStatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    HasTaskStat = table.Column<bool>(type: "bit", nullable: false),
                    CorrectAsnwerGiven = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageStats", x => x.PageStatID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseElements");

            migrationBuilder.DropTable(
                name: "CourseElementSequences");

            migrationBuilder.DropTable(
                name: "PageStats");
        }
    }
}
