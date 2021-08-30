using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorImp.Migrations
{
    public partial class TaskType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TaskType",
                table: "TaskPageModels",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskType",
                table: "TaskPageModels");
        }
    }
}
