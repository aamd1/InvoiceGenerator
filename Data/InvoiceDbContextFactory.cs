using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MyInvoiceGenerator.Data;

public sealed class InvoiceDbContextFactory : IDesignTimeDbContextFactory<InvoiceDbContext>
{
    public InvoiceDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .AddEnvironmentVariables()
            .Build();
        var connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? "Server=localhost;Database=InvoiceGenerator;User Id=sa;Password=DesignTimeOnly_Password1!;Encrypt=True;TrustServerCertificate=True";

        var options = new DbContextOptionsBuilder<InvoiceDbContext>()
            .UseSqlServer(connectionString)
            .Options;
        return new InvoiceDbContext(options);
    }
}
