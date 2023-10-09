using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WoC.Fit.Backend.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "HEB" },
                    { 2, "SCIFIT" },
                    { 3, "ALLMAX" },
                    { 4, "Wellthy" },
                    { 5, "Lysi" },
                    { 6, "Menissez" },
                    { 7, "KIRKLAND" },
                    { 8, "Columbus" }
                });

            migrationBuilder.InsertData(
                table: "Macronutrients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Proteina" },
                    { 2, "Grasas" },
                    { 3, "Carbohidratos" }
                });

            migrationBuilder.InsertData(
                table: "PortionType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gramos" },
                    { 2, "Mililitros" },
                    { 3, "Pieza" },
                    { 4, "Rebanada" },
                    { 5, "Cucharada" },
                    { 6, "Taza" },
                    { 7, "Cucharadita" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Suplemento Proteico" },
                    { 2, "Suplemento Nutricional" },
                    { 3, "Fruta" },
                    { 4, "Carne" },
                    { 5, "Huevo" },
                    { 6, "Leche Vegetal" },
                    { 7, "Panadería" },
                    { 8, "Aceite" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Calories", "Carbohydrates", "Fats", "MacronutrientId", "Name", "Portion", "PortionTypeId", "ProductTypeId", "Protein", "Sodium" },
                values: new object[,]
                {
                    { 1, 1, 110.0, 1.3, 0.51000000000000001, 1, "Whey Protein Vainilla", 31.300000000000001, 1, 1, 25.0, 104.86 },
                    { 2, 2, 119.59999999999999, 5.0, 0.40000000000000002, 1, "Whey Protein FrutiCereal", 24.0, 1, 1, 24.0, 119.0 },
                    { 3, 3, 130.0, 4.0, 2.0, 1, "Whey Protein PeanutButter", 32.0, 1, 1, 24.0, 130.0 },
                    { 4, 3, 130.0, 4.0, 2.0, 1, "Whey Protein Cookies & Cream", 32.0, 1, 1, 24.0, 150.0 },
                    { 5, 4, 124.0, 0.0, 0.59999999999999998, 1, "Peas Protein", 26.0, 1, 1, 26.0, 53.0 },
                    { 6, 5, 42.0, 0.0, 4.5999999999999996, 2, "Aceite de Pescado", 5.0, 2, 8, 0.0, 0.0 },
                    { 7, 1, 89.0, 23.0, 0.29999999999999999, 3, "Banana", 100.0, 1, 3, 1.1000000000000001, 1.0 },
                    { 8, 1, 122.0, 30.0, 0.20000000000000001, 3, "Pera Asiatica", 210.0, 1, 3, 1.0, 0.0 },
                    { 9, 1, 210.0, 0.0, 12.0, 1, "Diezmillo", 100.0, 1, 4, 21.0, 65.0 },
                    { 10, 1, 155.0, 0.0, 7.0, 1, "Top Sirlon", 100.0, 1, 4, 22.0, 56.0 },
                    { 11, 1, 149.0, 0.0, 7.4000000000000004, 1, "Aguja Nortena", 100.0, 1, 4, 19.300000000000001, 60.0 },
                    { 12, 1, 165.0, 0.0, 3.6000000000000001, 1, "Pechuga de Pollo", 100.0, 1, 4, 31.0, 65.0 },
                    { 13, 1, 65.0, 0.34000000000000002, 4.3700000000000001, 1, "Huevo Mediano", 1.0, 3, 5, 5.54, 70.0 },
                    { 14, 1, 74.0, 0.38, 4.9699999999999998, 1, "Huevo Grande", 1.0, 3, 5, 6.29, 80.0 },
                    { 15, 1, 90.0, 16.0, 2.5, 3, "Leche de Almendras Vainilla", 240.0, 2, 6, 1.0, 150.0 },
                    { 16, 1, 110.0, 23.0, 2.5, 3, "Leche de Almendras Chocolate", 240.0, 2, 6, 1.0, 230.0 },
                    { 17, 6, 233.0, 49.0, 1.0, 3, "Mini Bolillo", 100.0, 1, 7, 7.0, 490.0 },
                    { 18, 7, 828.0, 0.0, 92.0, 2, "Aceite de Semilla de Uva", 100.0, 2, 8, 0.0, 0.0 },
                    { 19, 8, 105.0, 1.0, 1.0, 1, "Pechuga de Pavo", 100.0, 1, 4, 23.0, 406.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PortionType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PortionType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PortionType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PortionType",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Macronutrients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Macronutrients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Macronutrients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PortionType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PortionType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PortionType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
