using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class RenameTrainingCostToCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_TrainingCost_CourseId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_TestQuestions_TrainingCost_CourseId",
                table: "TestQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_TestResults_TrainingCost_CourseId",
                table: "TestResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingVideos_TrainingCost_CourseId",
                table: "TrainingVideos");

            migrationBuilder.DropTable(
                name: "TrainingCost");

            migrationBuilder.CreateTable(
                name: "TrainingCourse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    TestDuration = table.Column<int>(nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCourse", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_TrainingCourse_CourseId",
                table: "Payments",
                column: "CourseId",
                principalTable: "TrainingCourse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestQuestions_TrainingCourse_CourseId",
                table: "TestQuestions",
                column: "CourseId",
                principalTable: "TrainingCourse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestResults_TrainingCourse_CourseId",
                table: "TestResults",
                column: "CourseId",
                principalTable: "TrainingCourse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingVideos_TrainingCourse_CourseId",
                table: "TrainingVideos",
                column: "CourseId",
                principalTable: "TrainingCourse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_TrainingCourse_CourseId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_TestQuestions_TrainingCourse_CourseId",
                table: "TestQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_TestResults_TrainingCourse_CourseId",
                table: "TestResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingVideos_TrainingCourse_CourseId",
                table: "TrainingVideos");

            migrationBuilder.DropTable(
                name: "TrainingCourse");

            migrationBuilder.CreateTable(
                name: "TrainingCost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestDuration = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCost", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_TrainingCost_CourseId",
                table: "Payments",
                column: "CourseId",
                principalTable: "TrainingCost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestQuestions_TrainingCost_CourseId",
                table: "TestQuestions",
                column: "CourseId",
                principalTable: "TrainingCost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestResults_TrainingCost_CourseId",
                table: "TestResults",
                column: "CourseId",
                principalTable: "TrainingCost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingVideos_TrainingCost_CourseId",
                table: "TrainingVideos",
                column: "CourseId",
                principalTable: "TrainingCost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
