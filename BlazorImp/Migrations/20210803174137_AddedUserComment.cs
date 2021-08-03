using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorImp.Migrations
{
    public partial class AddedUserComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "TaskAttempts",
                newName: "UserComment");

            migrationBuilder.AddColumn<string>(
                name: "UserAnswer",
                table: "TaskAttempts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAnswer",
                table: "TaskAttempts");

            migrationBuilder.RenameColumn(
                name: "UserComment",
                table: "TaskAttempts",
                newName: "Answer");
        }
    }
}
