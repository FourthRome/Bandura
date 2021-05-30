using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorImp.Migrations
{
    public partial class Modules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentPage",
                table: "Session");

            migrationBuilder.RenameColumn(
                name: "ParticipantID",
                table: "Session",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Session",
                newName: "StepNumber");

            migrationBuilder.AddColumn<int>(
                name: "ModuleID",
                table: "Session",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    ContentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentJson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.ContentID);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    ModuleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepNumber = table.Column<int>(type: "int", nullable: false),
                    ContentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.ModuleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropColumn(
                name: "ModuleID",
                table: "Session");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Session",
                newName: "ParticipantID");

            migrationBuilder.RenameColumn(
                name: "StepNumber",
                table: "Session",
                newName: "CourseID");

            migrationBuilder.AddColumn<string>(
                name: "CurrentPage",
                table: "Session",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
