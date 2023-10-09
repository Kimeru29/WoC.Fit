using Mapster;
using Microsoft.Extensions.Configuration;
using WoC.Fit.Backend.Api.ViewModels;
using WoC.Fit.Backend.Data.Models;


var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddEnvironmentVariables()
    .Build();

var h = configuration.GetConnectionString("NutriConnString");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDataLayer(configuration.GetConnectionString("NutriConnString"));
builder.Services.AddBusinessLayer();

TypeAdapterConfig<Product, ProductVM>.NewConfig()
    .Map(dest => dest.Id, src => src.Id)
    .Map(dest => dest.Name, src => src.Name)
    .Map(dest => dest.Brand, src => src.Brand.Name)
    .Map(dest => dest.ProductType, src => src.ProductType.Description)
    .Map(dest => dest.MainMacronutrient, src => src.MainMacronutrient.Name)
    .Map(dest => dest.Portion, src => $"{src.Portion} {src.PortionType.Name}")
    .Map(dest => dest.Calories, src => src.Calories)
    .Map(dest => dest.Sodium, src => src.Sodium)
    .Map(dest => dest.Protein, src => src.Protein)
    .Map(dest => dest.Carbohydrates, src => src.Carbohydrates)
    .Map(dest => dest.Fats, src => src.Fats);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

