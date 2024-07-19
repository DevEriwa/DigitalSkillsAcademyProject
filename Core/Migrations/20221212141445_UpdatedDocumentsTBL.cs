using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class UpdatedDocumentsTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicantDocumments_AspNetUsers_UserId",
                table: "ApplicantDocumments");

            migrationBuilder.DropIndex(
                name: "IX_ApplicantDocumments_UserId",
                table: "ApplicantDocumments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ApplicantDocumments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ApplicantDocumments");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "ApplicantDocumments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ApplicantDocumments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "ApplicantDocumments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantDocumments_StudentId",
                table: "ApplicantDocumments",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicantDocumments_AspNetUsers_StudentId",
                table: "ApplicantDocumments",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicantDocumments_AspNetUsers_StudentId",
                table: "ApplicantDocumments");

            migrationBuilder.DropIndex(
                name: "IX_ApplicantDocumments_StudentId",
                table: "ApplicantDocumments");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ApplicantDocumments");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "ApplicantDocumments");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "ApplicantDocumments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ApplicantDocumments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ApplicantDocumments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantDocumments_UserId",
                table: "ApplicantDocumments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicantDocumments_AspNetUsers_UserId",
                table: "ApplicantDocumments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
