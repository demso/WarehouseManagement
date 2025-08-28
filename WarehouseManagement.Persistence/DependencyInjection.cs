using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WarehouseManagement.Application.Interfaces;

namespace WarehouseManagement.Persistence;

public static class DependencyInjection {
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration) {
        services.AddDbContext<WarehouseDbContext>(optionsBuilder => {
                optionsBuilder.UseNpgsql(configuration.GetConnectionString(nameof(WarehouseDbContext)));
            })
            .AddScoped<IWarehouseDbContext>(provider => provider.GetRequiredService<WarehouseDbContext>());
        
        return services;
    }
}
