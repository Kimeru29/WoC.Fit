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
            new ProductType { Id = 1, Description = "Suplemento Proteico" },   
            new ProductType { Id = 2, Description = "Suplemento Nutricional" },
            new ProductType { Id = 3, Description = "Fruta" }, 
            new ProductType { Id = 4, Description = "Carne" }, 
            new ProductType { Id = 5, Description = "Huevo" }, 
            new ProductType { Id = 6, Description = "Leche Vegetal" },
            new ProductType { Id = 7, Description = "Panadería" }, 
            new ProductType { Id = 8, Description = "Aceite" },  
        };


        var macronutrients = new List<Macronutrient>
        {
            new Macronutrient { Id = 1, Name = "Proteina" },
            new Macronutrient { Id = 1, Name = "Grasas" },
            new Macronutrient { Id = 1, Name = "Carbohidratos" }
        };


        var portionTypes = new List<PortionType>
        {
            new PortionType { Id = 1, Name = "Gramos" },
            new PortionType { Id = 2, Name = "Mililitros" },
            new PortionType { Id = 3, Name = "Pieza" },
            new PortionType { Id = 4, Name = "Rebanada" },
            new PortionType { Id = 5, Name = "Cucharada" },
            new PortionType { Id = 6, Name = "Taza" },
            new PortionType { Id = 7, Name = "Cucharadita" },            
        };

        var products = new List<Product>
        {
            new Product
            {                
                Name = "Whey Protein Vainilla",
                Portion = 31.3,
                Calories = 110,
                Sodium = 104.86,
                Protein = 25.00,
                Carbohydrates = 1.30,
                Fats = 0.51,
                BrandId = 1,
                ProductTypeId = 1,
                MacronutrientId = 1,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Whey Protein FrutiCereal",
                Portion = 24,
                Calories = 119.6,
                Sodium = 119,
                Protein = 24.00,
                Carbohydrates = 5,
                Fats = 0.4,
                BrandId = 2,
                ProductTypeId = 1,
                MacronutrientId = 1,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Whey Protein PeanutButter",
                Portion = 32,
                Calories = 130,
                Sodium = 130,
                Protein = 24.00,
                Carbohydrates = 4,
                Fats = 2,
                BrandId = 3,
                ProductTypeId = 1,
                MacronutrientId = 1,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Whey Protein Cookies & Cream",
                Portion = 32,
                Calories = 130,
                Sodium = 150,
                Protein = 24.00,
                Carbohydrates = 4,
                Fats = 2,
                BrandId = 3,
                ProductTypeId = 1,
                MacronutrientId = 1,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Peas Protein",
                Portion = 26,
                Calories = 124,
                Sodium = 53,
                Protein = 26,
                Carbohydrates = 0,
                Fats = 0.6,
                BrandId = 4,
                ProductTypeId = 1,
                MacronutrientId = 1,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Aceite de Pescado",
                Portion = 5,
                Calories = 42,
                Sodium = 0,
                Protein = 0,
                Carbohydrates = 0,
                Fats = 4.6,
                BrandId = 5,
                ProductTypeId = 8,
                MacronutrientId = 2,
                PortionTypeId = 2,
            },
            new Product
            {
                Name = "Banana",
                Portion = 100,
                Calories = 89,
                Sodium = 1,
                Protein = 1.1,
                Carbohydrates = 23,
                Fats = 0.3,
                BrandId = 1,
                ProductTypeId = 3,
                MacronutrientId = 3,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Pera Asiatica",
                Portion = 210,
                Calories = 122,
                Sodium = 0,
                Protein = 1,
                Carbohydrates = 30,
                Fats = 0.2,
                BrandId = 1,
                ProductTypeId = 3,
                MacronutrientId = 3,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Diezmillo",
                Portion = 100,
                Calories = 210,
                Sodium = 65,
                Protein = 21,
                Carbohydrates = 0,
                Fats = 12,
                BrandId = 1,
                ProductTypeId = 4,
                MacronutrientId = 1,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Top Sirlon",
                Portion = 100,
                Calories = 155,
                Sodium = 56,
                Protein = 22,
                Carbohydrates = 0,
                Fats = 7,
                BrandId = 1,
                ProductTypeId = 4,
                MacronutrientId = 1,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Aguja Nortena",
                Portion = 100,
                Calories = 149,
                Sodium = 60,
                Protein = 19.30,
                Carbohydrates = 0,
                Fats = 7.4,
                BrandId = 1,
                ProductTypeId = 4,
                MacronutrientId = 1,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Pechuga de Pollo",
                Portion = 100,
                Calories = 165,
                Sodium = 65,
                Protein = 31,
                Carbohydrates = 0,
                Fats = 3.6,
                BrandId = 1,
                ProductTypeId = 4,
                MacronutrientId = 1,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Huevo Mediano",
                Portion = 1,
                Calories = 65,
                Sodium = 70,
                Protein = 5.54,
                Carbohydrates = 0.34,
                Fats = 4.37,
                BrandId = 1,
                ProductTypeId = 5,
                MacronutrientId = 1,
                PortionTypeId = 3,
            },
            new Product
            {
                Name = "Huevo Grande",
                Portion = 1,
                Calories = 74,
                Sodium = 80,
                Protein = 6.29,
                Carbohydrates = 0.38,
                Fats = 4.97,
                BrandId = 1,
                ProductTypeId = 5,
                MacronutrientId = 1,
                PortionTypeId = 3,
            },
            new Product
            {
                Name = "Leche de Almendras Vainilla",
                Portion = 240,
                Calories = 90,
                Sodium = 150,
                Protein = 1,
                Carbohydrates = 16,
                Fats = 2.5,
                BrandId = 1,
                ProductTypeId = 6,
                MacronutrientId = 3,
                PortionTypeId = 2,
            },
            new Product
            {
                Name = "Leche de Almendras Chocolate",
                Portion = 240,
                Calories = 110,
                Sodium = 230,
                Protein = 1,
                Carbohydrates = 23,
                Fats = 2.5,
                BrandId = 1,
                ProductTypeId = 6,
                MacronutrientId = 3,
                PortionTypeId = 2,
            },
            new Product
            {
                Name = "Mini Bolillo",
                Portion = 100,
                Calories = 233,
                Sodium = 490,
                Protein = 7,
                Carbohydrates = 49,
                Fats = 1,
                BrandId = 6,
                ProductTypeId = 7,
                MacronutrientId = 3,
                PortionTypeId = 1,
            },
            new Product
            {
                Name = "Aceite de Semilla de Uva",
                Portion = 100,
                Calories = 828,
                Sodium = 0,
                Protein = 0,
                Carbohydrates = 0,
                Fats = 92,
                BrandId = 7,
                ProductTypeId = 8,
                MacronutrientId = 2,
                PortionTypeId = 2,
            },
            new Product
            {
                Name = "Pechuga de Pavo",
                Portion = 100,
                Calories = 105,
                Sodium = 406,
                Protein = 23,
                Carbohydrates = 1,
                Fats = 1,
                BrandId = 8,
                ProductTypeId = 4,
                MacronutrientId = 1,
                PortionTypeId = 1,
            }
        };

        modelBuilder.Entity<Brand>().HasData(brands);
        modelBuilder.Entity<ProductType>().HasData(productTypes);
        modelBuilder.Entity<Macronutrient>().HasData(macronutrients);
        modelBuilder.Entity<PortionType>().HasData(portionTypes);
        modelBuilder.Entity<Product>().HasData(products);
    }
}
