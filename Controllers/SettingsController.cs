using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyInvoiceGenerator.Data;
using MyInvoiceGenerator.Models;

namespace MyInvoiceGenerator.Controllers;

public class SettingsController(InvoiceDbContext db) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Edit() => View(await db.InvoiceSettings.SingleAsync());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(InvoiceSettings settings)
    {
        if (!ModelState.IsValid) return View(settings);

        var stored = await db.InvoiceSettings.SingleAsync();
        db.Entry(stored).CurrentValues.SetValues(settings);
        await db.SaveChangesAsync();
        TempData["Message"] = "Invoice defaults saved.";
        return RedirectToAction(nameof(Edit));
    }
}