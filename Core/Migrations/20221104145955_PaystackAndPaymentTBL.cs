using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class PaystackAndPaymentTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "TrainingCourse",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceNumber",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProveOfPayment",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Source",
                table: "Payments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Paystacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    amount = table.Column<decimal>(nullable: true),
                    PaymentHistoryId = table.Column<int>(nullable: true),
                    currency = table.Column<string>(nullable: true),
                    transaction_date = table.Column<DateTime>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    reference = table.Column<string>(nullable: true),
                    domain = table.Column<string>(nullable: true),
                    gateway_response = table.Column<string>(nullable: true),
                    message = table.Column<string>(nullable: true),
                    channel = table.Column<string>(nullable: true),
                    ip_address = table.Column<string>(nullable: true),
                    fees = table.Column<string>(nullable: true),
                    last4 = table.Column<string>(nullable: true),
                    exp_month = table.Column<string>(nullable: true),
                    exp_year = table.Column<string>(nullable: true),
                    card_type = table.Column<string>(nullable: true),
                    bank = table.Column<string>(nullable: true),
                    country_code = table.Column<string>(nullable: true),
                    brand = table.Column<string>(nullable: true),
                    reusable = table.Column<bool>(nullable: true),
                    signature = table.Column<string>(nullable: true),
                    authorization_url = table.Column<string>(nullable: true),
                    access_code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paystacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paystacks_Payments_PaymentHistoryId",
                        column: x => x.PaymentHistoryId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paystacks_PaymentHistoryId",
                table: "Paystacks",
                column: "PaymentHistoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paystacks");

            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ProveOfPayment",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Payments");

            migrationBuilder.AlterColumn<string>(
                name: "Amount",
                table: "TrainingCourse",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
