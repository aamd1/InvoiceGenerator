using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyInvoiceGenerator.Migrations
{
    /// <inheritdoc />
    public partial class SplitPartyAddresses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientCity",
                table: "InvoiceSettings",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClientCountry",
                table: "InvoiceSettings",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClientPostalCode",
                table: "InvoiceSettings",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClientStreet",
                table: "InvoiceSettings",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClientStreetNumber",
                table: "InvoiceSettings",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyCity",
                table: "InvoiceSettings",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyCountry",
                table: "InvoiceSettings",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyPostalCode",
                table: "InvoiceSettings",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyStreet",
                table: "InvoiceSettings",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyStreetNumber",
                table: "InvoiceSettings",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClientCity",
                table: "Invoices",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClientCountry",
                table: "Invoices",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClientPostalCode",
                table: "Invoices",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClientStreet",
                table: "Invoices",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClientStreetNumber",
                table: "Invoices",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyCity",
                table: "Invoices",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyCountry",
                table: "Invoices",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyPostalCode",
                table: "Invoices",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyStreet",
                table: "Invoices",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyStreetNumber",
                table: "Invoices",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientCity",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "ClientCountry",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "ClientPostalCode",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "ClientStreet",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "ClientStreetNumber",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "CompanyCity",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "CompanyCountry",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "CompanyPostalCode",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "CompanyStreet",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "CompanyStreetNumber",
                table: "InvoiceSettings");

            migrationBuilder.DropColumn(
                name: "ClientCity",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ClientCountry",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ClientPostalCode",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ClientStreet",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ClientStreetNumber",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CompanyCity",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CompanyCountry",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CompanyPostalCode",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CompanyStreet",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CompanyStreetNumber",
                table: "Invoices");
        }
    }
}
