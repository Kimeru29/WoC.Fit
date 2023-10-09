using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WoC.Fit.Backend.Data.Repositories.Interfaces;
using WoC.Fit.Backend.Data.Repositories;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataLayer(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<NutriContext>(options =>
            options.UseSqlServer(connectionString));
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
