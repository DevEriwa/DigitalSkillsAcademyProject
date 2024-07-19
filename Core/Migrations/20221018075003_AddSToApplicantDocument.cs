using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class AddSToApplicantDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicantDocumment_AspNetUsers_UserId",
                table: "ApplicantDocumment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicantDocumment",
                table: "ApplicantDocumment");

            migrationBuilder.RenameTable(
                name: "ApplicantDocumment",
                newName: "ApplicantDocumments");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicantDocumment_UserId",
                table: "ApplicantDocumments",
                newName: "IX_ApplicantDocumments_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicantDocumments",
                table: "ApplicantDocumments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicantDocumments_AspNetUsers_UserId",
                table: "ApplicantDocumments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicantDocumments_AspNetUsers_UserId",
                table: "ApplicantDocumments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicantDocumments",
                table: "ApplicantDocumments");

            migrationBuilder.RenameTable(
                name: "ApplicantDocumments",
                newName: "ApplicantDocumment");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicantDocumments_UserId",
                table: "ApplicantDocumment",
                newName: "IX_ApplicantDocumment_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicantDocumment",
                table: "ApplicantDocumment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicantDocumment_AspNetUsers_UserId",
                table: "ApplicantDocumment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
