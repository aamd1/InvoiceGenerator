using Microsoft.EntityFrameworkCore;
using MyInvoiceGenerator.Models;

namespace MyInvoiceGenerator.Data;

public class InvoiceDbContext(DbContextOptions<InvoiceDbContext> options) : DbContext(options)
{
    public DbSet<Invoice> Invoices => Set<Invoice>();
    public DbSet<InvoiceItem> InvoiceItems => Set<InvoiceItem>();
    public DbSet<InvoiceSettings> InvoiceSettings => Set<InvoiceSettings>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Invoice>().Property(invoice => invoice.VatRate).HasPrecision(5, 2);
        modelBuilder.Entity<InvoiceItem>().Property(item => item.Quantity).HasPrecision(12, 2);
        modelBuilder.Entity<InvoiceItem>().Property(item => item.UnitPrice).HasPrecision(12, 2);
        modelBuilder.Entity<InvoiceSettings>().Property(settings => settings.VatRate).HasPrecision(5, 2);
        modelBuilder.Entity<InvoiceSettings>().Property(settings => settings.ItemQuantity).HasPrecision(12, 2);
        modelBuilder.Entity<InvoiceSettings>().Property(settings => settings.ItemUnitPrice).HasPrecision(12, 2);
        modelBuilder.Entity<InvoiceItem>().HasOne(item => item.Invoice).WithMany(invoice => invoice.Items)
            .HasForeignKey(item => item.InvoiceId).OnDelete(DeleteBehavior.Cascade);
    }
}