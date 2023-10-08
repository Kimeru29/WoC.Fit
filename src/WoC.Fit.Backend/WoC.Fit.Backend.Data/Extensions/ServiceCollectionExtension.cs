using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataLayer(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<NutriContext>(options =>
            options.UseSqlServer(connectionString));        

        return services;
    }
}
