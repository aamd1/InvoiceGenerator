using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using MyInvoiceGenerator.Data;

#nullable disable

namespace MyInvoiceGenerator.Migrations
{
    [DbContext(typeof(InvoiceDbContext))]
    [Migration("20260928100000_MakeInvoiceContactAndTermsOptional")]
    public partial class MakeInvoiceContactAndTermsOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(name: "CompanyEmail", table: "Invoices", type: "nvarchar(120)", maxLength: 120, nullable: true, oldClrType: typeof(string), oldType: "nvarchar(120)", oldMaxLength: 120);
            migrationBuilder.AlterColumn<string>(name: "CompanyPhone", table: "Invoices", type: "nvarchar(40)", maxLength: 40, nullable: true, oldClrType: typeof(string), oldType: "nvarchar(40)", oldMaxLength: 40);
            migrationBuilder.AlterColumn<string>(name: "ClientPhone", table: "Invoices", type: "nvarchar(40)", maxLength: 40, nullable: true, oldClrType: typeof(string), oldType: "nvarchar(40)", oldMaxLength: 40);
            migrationBuilder.AlterColumn<string>(name: "PaymentTerms", table: "Invoices", type: "nvarchar(1000)", maxLength: 1000, nullable: true, oldClrType: typeof(string), oldType: "nvarchar(1000)", oldMaxLength: 1000);
            migrationBuilder.AlterColumn<string>(name: "Details", table: "InvoiceItems", type: "nvarchar(500)", maxLength: 500, nullable: true, oldClrType: typeof(string), oldType: "nvarchar(500)", oldMaxLength: 500);
            migrationBuilder.AlterColumn<string>(name: "CompanyEmail", table: "InvoiceSettings", type: "nvarchar(120)", maxLength: 120, nullable: true, oldClrType: typeof(string), oldType: "nvarchar(120)", oldMaxLength: 120);
            migrationBuilder.AlterColumn<string>(name: "CompanyPhone", table: "InvoiceSettings", type: "nvarchar(40)", maxLength: 40, nullable: true, oldClrType: typeof(string), oldType: "nvarchar(40)", oldMaxLength: 40);
            migrationBuilder.AlterColumn<string>(name: "ClientPhone", table: "InvoiceSettings", type: "nvarchar(40)", maxLength: 40, nullable: true, oldClrType: typeof(string), oldType: "nvarchar(40)", oldMaxLength: 40);
            migrationBuilder.AlterColumn<string>(name: "PaymentTerms", table: "InvoiceSettings", type: "nvarchar(1000)", maxLength: 1000, nullable: true, oldClrType: typeof(string), oldType: "nvarchar(1000)", oldMaxLength: 1000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(name: "CompanyEmail", table: "Invoices", type: "nvarchar(120)", maxLength: 120, nullable: false, defaultValue: "", oldClrType: typeof(string), oldType: "nvarchar(120)", oldMaxLength: 120, oldNullable: true);
            migrationBuilder.AlterColumn<string>(name: "CompanyPhone", table: "Invoices", type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValue: "", oldClrType: typeof(string), oldType: "nvarchar(40)", oldMaxLength: 40, oldNullable: true);
            migrationBuilder.AlterColumn<string>(name: "ClientPhone", table: "Invoices", type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValue: "", oldClrType: typeof(string), oldType: "nvarchar(40)", oldMaxLength: 40, oldNullable: true);
            migrationBuilder.AlterColumn<string>(name: "PaymentTerms", table: "Invoices", type: "nvarchar(1000)", maxLength: 1000, nullable: false, defaultValue: "", oldClrType: typeof(string), oldType: "nvarchar(1000)", oldMaxLength: 1000, oldNullable: true);
            migrationBuilder.AlterColumn<string>(name: "Details", table: "InvoiceItems", type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValue: "", oldClrType: typeof(string), oldType: "nvarchar(500)", oldMaxLength: 500, oldNullable: true);
            migrationBuilder.AlterColumn<string>(name: "CompanyEmail", table: "InvoiceSettings", type: "nvarchar(120)", maxLength: 120, nullable: false, defaultValue: "", oldClrType: typeof(string), oldType: "nvarchar(120)", oldMaxLength: 120, oldNullable: true);
            migrationBuilder.AlterColumn<string>(name: "CompanyPhone", table: "InvoiceSettings", type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValue: "", oldClrType: typeof(string), oldType: "nvarchar(40)", oldMaxLength: 40, oldNullable: true);
            migrationBuilder.AlterColumn<string>(name: "ClientPhone", table: "InvoiceSettings", type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValue: "", oldClrType: typeof(string), oldType: "nvarchar(40)", oldMaxLength: 40, oldNullable: true);
            migrationBuilder.AlterColumn<string>(name: "PaymentTerms", table: "InvoiceSettings", type: "nvarchar(1000)", maxLength: 1000, nullable: false, defaultValue: "", oldClrType: typeof(string), oldType: "nvarchar(1000)", oldMaxLength: 1000, oldNullable: true);
        }
    }
}