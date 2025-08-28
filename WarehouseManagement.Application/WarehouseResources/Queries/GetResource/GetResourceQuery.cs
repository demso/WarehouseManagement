using WarehouseManagement.Application.Common.CQRS;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.WarehouseResources.Queries.GetResource;

public class GetResourceQuery : IQuery<WarehouseResource> {
    public required Guid Id { get; set; }
}
