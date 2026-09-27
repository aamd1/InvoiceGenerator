using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyInvoiceGenerator.Migrations
{
    /// <inheritdoc />
    public partial class InitialSqlServerSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CompanyIdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyStreetNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CompanyStreet = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyStreetLine2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CompanyPostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CompanyCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyCountry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CompanyPhone = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ClientIdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClientStreetNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClientStreet = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ClientStreetLine2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ClientPostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClientCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClientCountry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClientEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ClientPhone = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    VatRate = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Iban = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Bic = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PaymentTerms = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumberPrefix = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    DueDays = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CompanyIdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyStreetNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CompanyStreet = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyStreetLine2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CompanyPostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CompanyCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyCountry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CompanyPhone = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ClientIdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClientStreetNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClientStreet = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ClientStreetLine2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ClientPostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClientCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClientCountry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClientEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ClientPhone = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    VatRate = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Iban = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Bic = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PaymentTerms = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ItemDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ItemDetails = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ItemQuantity = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    ItemUnitPrice = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    ItemVatRate = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    VatRate = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "InvoiceSettings");

            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
