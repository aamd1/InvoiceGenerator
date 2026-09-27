using System.ComponentModel.DataAnnotations;

namespace MyInvoiceGenerator.Models;

public class Invoice
{
    public int Id { get; set; }
    [Required, StringLength(30)] public string InvoiceNumber { get; set; } = "";
    [Required, StringLength(2)] public string Language { get; set; } = "en";
    [DataType(DataType.Date)] public DateTime IssueDate { get; set; } = DateTime.Today;
    [DataType(DataType.Date)] public DateTime DueDate { get; set; } = DateTime.Today.AddDays(14);
    [Required, StringLength(120)] public string CompanyName { get; set; } = "Your Company Ltd.";
    [StringLength(50)] public string CompanyIdNumber { get; set; } = "";
    [StringLength(20)] public string CompanyStreetNumber { get; set; } = "123";
    [StringLength(150)] public string CompanyStreet { get; set; } = "Business Street";
    [StringLength(150)] public string? CompanyStreetLine2 { get; set; }
    [StringLength(20)] public string CompanyPostalCode { get; set; } = "75001";
    [StringLength(100)] public string CompanyCity { get; set; } = "Paris";
    [StringLength(100)] public string CompanyCountry { get; set; } = "France";
    [EmailAddress, StringLength(120)] public string CompanyEmail { get; set; } = "";
    [StringLength(40)] public string CompanyPhone { get; set; } = "";
    [Required, StringLength(120)] public string ClientName { get; set; } = "";
    [StringLength(50)] public string ClientIdNumber { get; set; } = "";
    [StringLength(20)] public string ClientStreetNumber { get; set; } = "456";
    [StringLength(150)] public string ClientStreet { get; set; } = "Client Street";
    [StringLength(150)] public string? ClientStreetLine2 { get; set; }
    [StringLength(20)] public string ClientPostalCode { get; set; } = "75002";
    [StringLength(100)] public string ClientCity { get; set; } = "Paris";
    [StringLength(100)] public string ClientCountry { get; set; } = "France";
    [EmailAddress, StringLength(120)] public string ClientEmail { get; set; } = "";
    [StringLength(40)] public string ClientPhone { get; set; } = "";
    [Range(0, 100)] public decimal VatRate { get; set; } = 20;
    [StringLength(2000)] public string Notes { get; set; } = "";
    [StringLength(120)] public string BeneficiaryName { get; set; } = "";
    [StringLength(80)] public string Iban { get; set; } = "";
    [StringLength(30)] public string Bic { get; set; } = "";
    [StringLength(1000)] public string PaymentTerms { get; set; } = "";
    public List<InvoiceItem> Items { get; set; } = new();
    public decimal Subtotal => Items.Sum(item => item.Quantity * item.UnitPrice);
    public decimal VatAmount => Items.Sum(item => item.VatAmount);
    public decimal Total => Subtotal + VatAmount;
}

public class InvoiceItem
{
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    public Invoice? Invoice { get; set; }
    [Required, StringLength(200)] public string Description { get; set; } = "";
    [StringLength(500)] public string Details { get; set; } = "";
    [Range(0.01, 1000000)] public decimal Quantity { get; set; } = 1;
    [Range(0, 100000000)] public decimal UnitPrice { get; set; }
    [Range(0, 100)] public decimal VatRate { get; set; } = 20;
    public decimal Amount => Quantity * UnitPrice;
    public decimal VatAmount => Amount * VatRate / 100;
}

public class InvoiceSettings
{
    public int Id { get; set; }
    [StringLength(30)] public string InvoiceNumberPrefix { get; set; } = "INV-";
    [Required, StringLength(2)] public string Language { get; set; } = "en";
    public int DueDays { get; set; } = 14;
    [StringLength(120)] public string CompanyName { get; set; } = "Your Company Ltd.";
    [StringLength(50)] public string CompanyIdNumber { get; set; } = "";
    [StringLength(20)] public string CompanyStreetNumber { get; set; } = "123";
    [StringLength(150)] public string CompanyStreet { get; set; } = "Business Street";
    [StringLength(150)] public string? CompanyStreetLine2 { get; set; }
    [StringLength(20)] public string CompanyPostalCode { get; set; } = "75001";
    [StringLength(100)] public string CompanyCity { get; set; } = "Paris";
    [StringLength(100)] public string CompanyCountry { get; set; } = "France";
    [StringLength(120)] public string CompanyEmail { get; set; } = "";
    [StringLength(40)] public string CompanyPhone { get; set; } = "";
    [StringLength(120)] public string ClientName { get; set; } = "";
    [StringLength(50)] public string ClientIdNumber { get; set; } = "";
    [StringLength(20)] public string ClientStreetNumber { get; set; } = "456";
    [StringLength(150)] public string ClientStreet { get; set; } = "Client Street";
    [StringLength(150)] public string? ClientStreetLine2 { get; set; }
    [StringLength(20)] public string ClientPostalCode { get; set; } = "75002";
    [StringLength(100)] public string ClientCity { get; set; } = "Paris";
    [StringLength(100)] public string ClientCountry { get; set; } = "France";
    [StringLength(120)] public string ClientEmail { get; set; } = "";
    [StringLength(40)] public string ClientPhone { get; set; } = "";
    public decimal VatRate { get; set; } = 20;
    [StringLength(2000)] public string Notes { get; set; } = "";
    [StringLength(120)] public string BeneficiaryName { get; set; } = "";
    [StringLength(80)] public string Iban { get; set; } = "";
    [StringLength(30)] public string Bic { get; set; } = "";
    [StringLength(1000)] public string PaymentTerms { get; set; } = "";
    [StringLength(200)] public string ItemDescription { get; set; } = "";
    [StringLength(500)] public string ItemDetails { get; set; } = "";
    public decimal ItemQuantity { get; set; } = 1;
    public decimal ItemUnitPrice { get; set; }
    public decimal ItemVatRate { get; set; } = 20;
}