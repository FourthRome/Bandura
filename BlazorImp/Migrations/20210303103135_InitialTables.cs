using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorImp.Migrations
{
    public partial class InitialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionsEntity",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsEntity", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "UserActionsEntity",
                columns: table => new
                {
                    UserActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Timestamp = table.Column<long>(type: "bigint", nullable: true),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActionsEntity", x => x.UserActionId);
                    table.ForeignKey(
                        name: "FK_UserActionsEntity_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionAdditionalDataEntity",
                columns: table => new
                {
                    QuestionAdditionalDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAdditionalDataEntity", x => x.QuestionAdditionalDataId);
                    table.ForeignKey(
                        name: "FK_QuestionAdditionalDataEntity_QuestionsEntity_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionsEntity",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionAttemptsEntity",
                columns: table => new
                {
                    QuestionAttemptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AttemptNumber = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: true),
                    UserInput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAttemptsEntity", x => x.QuestionAttemptId);
                    table.ForeignKey(
                        name: "FK_QuestionAttemptsEntity_IdentityUser_UserId1",
                        column: x => x.UserId1,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionAttemptsEntity_QuestionsEntity_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionsEntity",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuizDetailsEntity",
                columns: table => new
                {
                    QuizDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizDetailsEntity", x => x.QuizDetailsId);
                    table.ForeignKey(
                        name: "FK_QuizDetailsEntity_QuestionsEntity_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionsEntity",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RightAnswersEntity",
                columns: table => new
                {
                    RightAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RightAnswersEntity", x => x.RightAnswerId);
                    table.ForeignKey(
                        name: "FK_RightAnswersEntity_QuestionsEntity_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionsEntity",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAdditionalDataEntity_QuestionId",
                table: "QuestionAdditionalDataEntity",
                column: "QuestionId",
                unique: true,
                filter: "[QuestionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAttemptsEntity_QuestionId",
                table: "QuestionAttemptsEntity",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAttemptsEntity_UserId1",
                table: "QuestionAttemptsEntity",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_QuizDetailsEntity_QuestionId",
                table: "QuizDetailsEntity",
                column: "QuestionId",
                unique: true,
                filter: "[QuestionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RightAnswersEntity_QuestionId",
                table: "RightAnswersEntity",
                column: "QuestionId",
                unique: true,
                filter: "[QuestionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserActionsEntity_UserId",
                table: "UserActionsEntity",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionAdditionalDataEntity");

            migrationBuilder.DropTable(
                name: "QuestionAttemptsEntity");

            migrationBuilder.DropTable(
                name: "QuizDetailsEntity");

            migrationBuilder.DropTable(
                name: "RightAnswersEntity");

            migrationBuilder.DropTable(
                name: "UserActionsEntity");

            migrationBuilder.DropTable(
                name: "QuestionsEntity");

            migrationBuilder.DropTable(
                name: "IdentityUser");
        }
    }
}
