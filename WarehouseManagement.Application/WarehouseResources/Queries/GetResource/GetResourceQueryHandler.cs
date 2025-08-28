using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.WarehouseResources.Queries.GetResource;

public class GetResourceQueryHandler(IWarehouseDbContext dbContext) : AbstractResourceRequestHandler<GetResourceQuery, WarehouseResource>(dbContext) {
    public override async Task<WarehouseResource> Handle(GetResourceQuery request, CancellationToken cancellationToken) {
        return await GetValidResource(request.Id, cancellationToken);
    }
}
