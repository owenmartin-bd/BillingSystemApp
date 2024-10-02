namespace BillingSystemApp.DBContext;

using Microsoft.EntityFrameworkCore;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<OpeningInvoice> OpeningInvoices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the OpeningInvoice entity
        modelBuilder.Entity<OpeningInvoice>()
            .ToTable("OpeningInvoice");

        // Additional configurations can be added here
    }
}