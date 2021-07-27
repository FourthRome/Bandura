using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorImp.Migrations
{
    public partial class FixFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaskPageID",
                table: "TaskAttempts",
                newName: "TaskPageModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaskPageModelID",
                table: "TaskAttempts",
                newName: "TaskPageID");
        }
    }
}
