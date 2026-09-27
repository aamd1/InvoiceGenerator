using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyInvoiceGenerator.Migrations
{
    /// <inheritdoc />
    public partial class RenameBankNameToBeneficiaryName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BankName",
                table: "InvoiceSettings",
                newName: "BeneficiaryName");

            migrationBuilder.RenameColumn(
                name: "BankName",
                table: "Invoices",
                newName: "BeneficiaryName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BeneficiaryName",
                table: "InvoiceSettings",
                newName: "BankName");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryName",
                table: "Invoices",
                newName: "BankName");
        }
    }
}
