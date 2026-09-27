using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyInvoiceGenerator.Migrations
{
    /// <inheritdoc />
    public partial class AddInvoiceLanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "InvoiceSettings",
                type: "varchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Invoices",
                type: "varchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Invoices");
        }
    }
}
