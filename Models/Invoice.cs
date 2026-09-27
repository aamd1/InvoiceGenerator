using System.ComponentModel.DataAnnotations;

namespace MyInvoiceGenerator.Models;

public class Invoice
{
    public int Id { get; set; }
    [Required, StringLength(30)] public string InvoiceNumber { get; set; } = "";
    [DataType(DataType.Date)] public DateTime IssueDate { get; set; } = DateTime.Today;
    [DataType(DataType.Date)] public DateTime DueDate { get; set; } = DateTime.Today.AddDays(14);
    [Required, StringLength(120)] public string CompanyName { get; set; } = "Your Company Ltd.";
    [StringLength(250)] public string CompanyAddress { get; set; } = "";
    [EmailAddress, StringLength(120)] public string CompanyEmail { get; set; } = "";
    [StringLength(40)] public string CompanyPhone { get; set; } = "";
    [Required, StringLength(120)] public string ClientName { get; set; } = "";
    [StringLength(250)] public string ClientAddress { get; set; } = "";
    [EmailAddress, StringLength(120)] public string ClientEmail { get; set; } = "";
    [StringLength(40)] public string ClientPhone { get; set; } = "";
    [Range(0, 100)] public decimal VatRate { get; set; } = 20;
    [StringLength(2000)] public string Notes { get; set; } = "";
    [StringLength(120)] public string BankName { get; set; } = "";
    [StringLength(80)] public string Iban { get; set; } = "";
    [StringLength(30)] public string Bic { get; set; } = "";
    [StringLength(1000)] public string PaymentTerms { get; set; } = "";
    public List<InvoiceItem> Items { get; set; } = new();
    public decimal Subtotal => Items.Sum(item => item.Quantity * item.UnitPrice);
    public decimal VatAmount => Subtotal * VatRate / 100;
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
    public decimal Amount => Quantity * UnitPrice;
}