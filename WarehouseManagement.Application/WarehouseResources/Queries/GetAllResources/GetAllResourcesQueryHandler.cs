using Microsoft.EntityFrameworkCore;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Application.WarehouseResources.Queries.GetResource;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.WarehouseResources.Queries.GetAllResources;

public class GetAllResourcesQueryHandler(IWarehouseDbContext dbContext) 
    : AbstractResourceRequestHandler<GetAllResourcesQuery, IEnumerable<WarehouseResource>>(dbContext) {
    private readonly IWarehouseDbContext _dbContext = dbContext;

    public override async Task<IEnumerable<WarehouseResource>> Handle(GetAllResourcesQuery request, 
        CancellationToken cancellationToken) {
        
        List<WarehouseResource> resources = await _dbContext.WarehouseResources
            .Where(x => x.State.Equals(request.State))
            .ToListAsync(cancellationToken);

        return resources;
    }
}
