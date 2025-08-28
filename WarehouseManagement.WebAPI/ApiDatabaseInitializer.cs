using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Persistence;

namespace WarehouseManagement.WebAPI;

public static class ApiDatabaseInitializer {
    public static async Task InitializeDatabase(this IApplicationBuilder app) {
        IWarehouseDbContext context = app.ApplicationServices.CreateScope().ServiceProvider
            .GetRequiredService<IWarehouseDbContext>();

        await DatabaseInitializer.InitializeDatabase(context);
    }
}
