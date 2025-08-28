using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.Interfaces;

public interface IWarehouseDbContext {
    DbSet<WarehouseResource> WarehouseResources { get; }
    DbSet<MeasurementUnit> MeasurementUnits { get; }
    DbSet<IncomingResourceDocument> IncomingResourceDocuments { get; }
    DbSet<IncomingResource> IncomingResources { get; }
    DatabaseFacade Database { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
