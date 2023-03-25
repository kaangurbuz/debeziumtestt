using Microsoft.EntityFrameworkCore;
using Write.API.Entities;

namespace Write.API.Context;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    { }

    public DbSet<Product> Product { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(x => x.Id);
            entity.Property(x => x.Code);
            entity.Property(x => x.Title);
            entity.Property(x => x.Price);
            entity.Property(x => x.CreatedOnUtc);
        });
    }
}
