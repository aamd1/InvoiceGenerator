using Microsoft.EntityFrameworkCore;
using MyInvoiceGenerator.Data;
using MyInvoiceGenerator.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("ConnectionStrings:DefaultConnection is not configured.");
builder.Services.AddDbContext<InvoiceDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<InvoiceDbContext>();
    var retries = 0;
    while (true)
    {
        try { db.Database.Migrate(); break; }
        catch when (retries++ < 12) { Thread.Sleep(TimeSpan.FromSeconds(2)); }
    }

    if (!db.InvoiceSettings.Any())
    {
        var latestInvoice = db.Invoices.OrderByDescending(invoice => invoice.Id).FirstOrDefault();
        var latestItem = db.InvoiceItems.OrderByDescending(item => item.Id).FirstOrDefault();
        db.InvoiceSettings.Add(new InvoiceSettings
        {
            CompanyName = latestInvoice?.CompanyName ?? "Your Company Ltd.",
            CompanyAddress = latestInvoice?.CompanyAddress ?? "",
            CompanyEmail = latestInvoice?.CompanyEmail ?? "",
            CompanyPhone = latestInvoice?.CompanyPhone ?? "",
            ClientName = latestInvoice?.ClientName ?? "",
            ClientAddress = latestInvoice?.ClientAddress ?? "",
            ClientEmail = latestInvoice?.ClientEmail ?? "",
            ClientPhone = latestInvoice?.ClientPhone ?? "",
            VatRate = latestInvoice?.VatRate ?? 20,
            Notes = latestInvoice?.Notes ?? "",
            BankName = latestInvoice?.BankName ?? "",
            Iban = latestInvoice?.Iban ?? "",
            Bic = latestInvoice?.Bic ?? "",
            PaymentTerms = latestInvoice?.PaymentTerms ?? "",
            ItemDescription = latestItem?.Description ?? "",
            ItemDetails = latestItem?.Details ?? "",
            ItemQuantity = latestItem?.Quantity ?? 1,
            ItemUnitPrice = latestItem?.UnitPrice ?? 0
        });
        db.SaveChanges();
    }
}

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
