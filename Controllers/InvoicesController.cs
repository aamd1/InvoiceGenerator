using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyInvoiceGenerator.Data;
using MyInvoiceGenerator.Models;

namespace MyInvoiceGenerator.Controllers;

public class InvoicesController(InvoiceDbContext db) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index() => View(await db.Invoices.OrderByDescending(invoice => invoice.IssueDate).ToListAsync());

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var defaults = await db.InvoiceSettings.AsNoTracking().SingleAsync();

        var invoice = new Invoice
        {
            InvoiceNumber = $"{defaults.InvoiceNumberPrefix}{DateTime.UtcNow:yyyyMMddHHmmss}",
            DueDate = DateTime.Today.AddDays(defaults.DueDays),
            CompanyName = defaults.CompanyName,
            CompanyStreetNumber = defaults.CompanyStreetNumber,
            CompanyStreet = defaults.CompanyStreet,
            CompanyStreetLine2 = defaults.CompanyStreetLine2,
            CompanyPostalCode = defaults.CompanyPostalCode,
            CompanyCity = defaults.CompanyCity,
            CompanyCountry = defaults.CompanyCountry,
            CompanyEmail = defaults.CompanyEmail,
            CompanyPhone = defaults.CompanyPhone,
            ClientName = defaults.ClientName,
            ClientStreetNumber = defaults.ClientStreetNumber,
            ClientStreet = defaults.ClientStreet,
            ClientStreetLine2 = defaults.ClientStreetLine2,
            ClientPostalCode = defaults.ClientPostalCode,
            ClientCity = defaults.ClientCity,
            ClientCountry = defaults.ClientCountry,
            ClientEmail = defaults.ClientEmail,
            ClientPhone = defaults.ClientPhone,
            VatRate = defaults.VatRate,
            Notes = defaults.Notes,
            BankName = defaults.BankName,
            Iban = defaults.Iban,
            Bic = defaults.Bic,
            PaymentTerms = defaults.PaymentTerms
        };
        invoice.Items.Add(new InvoiceItem
        {
            Description = defaults.ItemDescription,
            Details = defaults.ItemDetails,
            Quantity = defaults.ItemQuantity,
            UnitPrice = defaults.ItemUnitPrice,
            VatRate = defaults.ItemVatRate
        });
        return View(invoice);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Invoice invoice)
    {
        invoice.Items = invoice.Items.Where(item => !string.IsNullOrWhiteSpace(item.Description)).ToList();
        if (invoice.Items.Count == 0) ModelState.AddModelError("Items", "Add at least one invoice item.");
        if (!ModelState.IsValid) return View(invoice);
        db.Invoices.Add(invoice);
        await db.SaveChangesAsync();
        return RedirectToAction(nameof(Details), new { id = invoice.Id });
    }

    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var invoice = await db.Invoices.Include(item => item.Items).SingleOrDefaultAsync(item => item.Id == id);
        return invoice is null ? NotFound() : View(invoice);
    }
}