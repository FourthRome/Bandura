using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorImp.Migrations
{
    public partial class StatPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAsnwerGiven",
                table: "PageStats");

            migrationBuilder.RenameColumn(
                name: "HasTaskStat",
                table: "PageStats",
                newName: "CorrectAnswerGiven");

            migrationBuilder.AddColumn<int>(
                name: "PageID",
                table: "PageStats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageID",
                table: "PageStats");

            migrationBuilder.RenameColumn(
                name: "CorrectAnswerGiven",
                table: "PageStats",
                newName: "HasTaskStat");

            migrationBuilder.AddColumn<bool>(
                name: "CorrectAsnwerGiven",
                table: "PageStats",
                type: "bit",
                nullable: true);
        }
    }
}
