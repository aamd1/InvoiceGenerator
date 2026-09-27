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
    public IActionResult Create()
    {
        var invoice = new Invoice { InvoiceNumber = $"INV-{DateTime.UtcNow:yyyyMMddHHmmss}" };
        invoice.Items.Add(new InvoiceItem());
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