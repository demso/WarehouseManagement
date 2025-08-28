using Microsoft.EntityFrameworkCore;
using WarehouseManagement.Application.Interfaces;

namespace WarehouseManagement.Persistence;

public static class DatabaseInitializer {
    public static async Task InitializeDatabase(IWarehouseDbContext context) {
        await context.Database.MigrateAsync();
    }
}
