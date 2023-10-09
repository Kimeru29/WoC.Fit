using Microsoft.Extensions.DependencyInjection;
using WoC.Fit.Backend.Data.Repositories.Interfaces;
using WoC.Fit.Backend.Data.Repositories;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        return services;
    }
}
