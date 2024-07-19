using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class OptionsTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_TrainingCourse_CourseId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingVideos_TrainingCourse_CourseId",
                table: "TrainingVideos");

            migrationBuilder.DropColumn(
                name: "Options",
                table: "TestQuestions");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "TrainingVideos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Payments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AnswerOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(nullable: true),
                    Option = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerOptions_TestQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "TestQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerOptions_QuestionId",
                table: "AnswerOptions",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_TrainingCourse_CourseId",
                table: "Payments",
                column: "CourseId",
                principalTable: "TrainingCourse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingVideos_TrainingCourse_CourseId",
                table: "TrainingVideos",
                column: "CourseId",
                principalTable: "TrainingCourse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_TrainingCourse_CourseId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingVideos_TrainingCourse_CourseId",
                table: "TrainingVideos");

            migrationBuilder.DropTable(
                name: "AnswerOptions");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "TrainingVideos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "TestQuestions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Payments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_TrainingCourse_CourseId",
                table: "Payments",
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
    }
}
