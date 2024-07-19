using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class UpdateProjectTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LinksIsAdded",
                table: "ProjectTopics",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RedmineLink",
                table: "ProjectTopics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinksIsAdded",
                table: "ProjectTopics");

            migrationBuilder.DropColumn(
                name: "RedmineLink",
                table: "ProjectTopics");
        }
    }
}
