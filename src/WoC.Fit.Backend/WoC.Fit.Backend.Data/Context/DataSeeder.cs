using Microsoft.EntityFrameworkCore;
using WoC.Fit.Backend.Data.Models;

public static class DataSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var brands = new List<Brand>
        {
            new Brand { Id = 1, Name = "HEB" },
            new Brand { Id = 2, Name = "SCIFIT" },
            new Brand { Id = 3, Name = "ALLMAX" },
            new Brand { Id = 4, Name = "Wellthy" },
            new Brand { Id = 5, Name = "Lysi" },
            new Brand { Id = 6, Name = "Menissez" },
            new Brand { Id = 7, Name = "KIRKLAND" },
            new Brand { Id = 8, Name = "Columbus" }
        };


        var productTypes = new List<ProductType>
        {
            new ProductType { Id = 1, Description = "Suplemento" },
            // ... Add other product types as required ...
        };

        var macronutrients = new List<Macronutrient>
        {
            new Macronutrient { Id = 1, Name = "Proteina" },
            new Macronutrient { Id = 1, Name = "Grasas" },
            new Macronutrient { Id = 1, Name = "Carbohidratos" }
        };

        var products = new List<Product>
        {
            new Product
            {                
                Name = "Whey Protein Vainilla",
                Portion = "31.3g",
                Calories = 110,
                Sodium = 104.86,
                Protein = 25.00,
                Carbohydrates = 1.30,
                Fats = 0.51,
                BrandId = 1,
                ProductTypeId = 1,
                MacronutrientId = 1
            },
            new Product
            {                
                Name = "Whey Protein Vainilla",
                Portion = "31.3g",
                Calories = 110,
                Sodium = 104.86,
                Protein = 25.00,
                Carbohydrates = 1.30,
                Fats = 0.51,
                BrandId = 1,
                ProductTypeId = 1,
                MacronutrientId = 1
            },
        };

        modelBuilder.Entity<Brand>().HasData(brands);
        modelBuilder.Entity<ProductType>().HasData(productTypes);
        modelBuilder.Entity<Macronutrient>().HasData(macronutrients);
        modelBuilder.Entity<Product>().HasData(products);
    }
}
