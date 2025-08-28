using System.Reflection;
using WarehouseManagement.Domain;
using Microsoft.EntityFrameworkCore;
using WarehouseManagement.Application;
using WarehouseManagement.Application.Interfaces;

namespace WarehouseManagement.Persistence;

public sealed class WarehouseDbContext(DbContextOptions options) : DbContext(options), IWarehouseDbContext{
    public DbSet<WarehouseResource> WarehouseResources => Set<WarehouseResource>();
    public DbSet<MeasurementUnit> MeasurementUnits => Set<MeasurementUnit>();
    public DbSet<IncomingResourceDocument> IncomingResourceDocuments => Set<IncomingResourceDocument>();
    public DbSet<IncomingResource> IncomingResources => Set<IncomingResource>();
    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
