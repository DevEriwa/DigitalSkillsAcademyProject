using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class AddSalaryReturnsTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalaryRetureHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    ReoccuringPaymentsId = table.Column<int>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryRetureHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalaryRetureHistory_ReoccuringPayments_ReoccuringPaymentsId",
                        column: x => x.ReoccuringPaymentsId,
                        principalTable: "ReoccuringPayments",
                        principalColumn: "MainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalaryRetureHistory_ReoccuringPaymentsId",
                table: "SalaryRetureHistory",
                column: "ReoccuringPaymentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalaryRetureHistory");
        }
    }
}
