using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class AddReoccuringPaymentTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReoccuringPayments",
                columns: table => new
                {
                    MainId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    interval = table.Column<string>(nullable: true),
                    invoice_limit = table.Column<int>(nullable: false),
                    amount = table.Column<int>(nullable: false),
                    integration = table.Column<int>(nullable: false),
                    domain = table.Column<string>(nullable: true),
                    currency = table.Column<string>(nullable: true),
                    plan_code = table.Column<string>(nullable: true),
                    send_invoices = table.Column<bool>(nullable: false),
                    send_sms = table.Column<bool>(nullable: false),
                    hosted_page = table.Column<bool>(nullable: false),
                    migrate = table.Column<bool>(nullable: false),
                    is_archived = table.Column<bool>(nullable: false),
                    id = table.Column<int>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    authorization_url = table.Column<string>(nullable: true),
                    IsAuthorized = table.Column<bool>(nullable: false),
                    access_code = table.Column<string>(nullable: true),
                    reference = table.Column<string>(nullable: true),
                    dateUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReoccuringPayments", x => x.MainId);
                    table.ForeignKey(
                        name: "FK_ReoccuringPayments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReoccuringPayments_UserId",
                table: "ReoccuringPayments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReoccuringPayments");
        }
    }
}
