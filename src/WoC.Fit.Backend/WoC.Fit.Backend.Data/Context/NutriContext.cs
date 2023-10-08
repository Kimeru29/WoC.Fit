using Microsoft.EntityFrameworkCore;
using WoC.Fit.Backend.Data.Models;

public class NutriContext : DbContext
{
    public NutriContext(DbContextOptions<NutriContext> options)
        : base(options)
    { }

    public DbSet<Brand> Brands { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<Macronutrient> Macronutrients { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {        

        modelBuilder.Entity<Product>()
            .HasOne(p => p.Brand)
            .WithMany(b => b.Products)
            .HasForeignKey(p => p.BrandId);

        modelBuilder.Entity<Product>()
            .HasOne(p => p.ProductType)
            .WithMany(pt => pt.Products)
            .HasForeignKey(p => p.ProductTypeId);

        modelBuilder.Entity<Product>()
            .HasOne(p => p.MainMacronutrient)
            .WithMany(m => m.Products)
            .HasForeignKey(p => p.MacronutrientId);
    }
}
