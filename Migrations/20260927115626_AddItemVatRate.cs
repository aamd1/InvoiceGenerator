using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyInvoiceGenerator.Migrations
{
    /// <inheritdoc />
    public partial class AddItemVatRate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ItemVatRate",
                table: "InvoiceSettings",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                defaultValue: 20m);

            migrationBuilder.AddColumn<decimal>(
                name: "VatRate",
                table: "InvoiceItems",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                defaultValue: 20m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemVatRate",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "VatRate",
                table: "InvoiceItems");
        }
    }
}
