using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorImp.Migrations
{
    public partial class FixNameMismatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserAnswer",
                table: "TaskPageModels",
                newName: "RightAnswer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RightAnswer",
                table: "TaskPageModels",
                newName: "UserAnswer");
        }
    }
}
