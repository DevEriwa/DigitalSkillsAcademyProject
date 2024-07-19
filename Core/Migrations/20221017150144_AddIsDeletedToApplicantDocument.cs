using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class AddIsDeletedToApplicantDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicantDocuments_AspNetUsers_UserId",
                table: "ApplicantDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicantDocuments",
                table: "ApplicantDocuments");

            migrationBuilder.RenameTable(
                name: "ApplicantDocuments",
                newName: "ApplicantDocumment");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicantDocuments_UserId",
                table: "ApplicantDocumment",
                newName: "IX_ApplicantDocumment_UserId");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ApplicantDocumment",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicantDocumment_AspNetUsers_UserId",
                table: "ApplicantDocumment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicantDocumment",
                table: "ApplicantDocumment");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ApplicantDocumment");

            migrationBuilder.RenameTable(
                name: "ApplicantDocumment",
                newName: "ApplicantDocuments");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicantDocumment_UserId",
                table: "ApplicantDocuments",
                newName: "IX_ApplicantDocuments_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicantDocuments",
                table: "ApplicantDocuments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicantDocuments_AspNetUsers_UserId",
                table: "ApplicantDocuments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
