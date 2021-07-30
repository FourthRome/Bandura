using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorImp.Migrations
{
    public partial class FixAnotherFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SurveyPageID",
                table: "SurveyAnswers",
                newName: "SurveyPageModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SurveyPageModelID",
                table: "SurveyAnswers",
                newName: "SurveyPageID");
        }
    }
}
