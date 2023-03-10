namespace PedidosApp.Infra.Data;
using Microsoft.EntityFrameworkCore;
using PedidosApp.Domain.Products;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Product>()
            .Property(p => p.Name).IsRequired();
        builder.Entity<Product>()
            .Property(p => p.Description).HasMaxLength(255);

        builder.Entity<Category>()
            .Property(c => c.Name).IsRequired();
       
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
    {
        configuration.Properties<string>()
            .HaveMaxLength(100);
    }

}
