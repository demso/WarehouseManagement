using MediatR;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.WarehouseResources.Commands.RemoveResource;

public class RemoveResourceCommandHandler(IWarehouseDbContext dbContext) : AbstractResourceRequestHandler<RemoveResourceCommand, Unit>(dbContext) {
    private readonly IWarehouseDbContext _dbContext = dbContext;

    public override async Task<Unit> Handle(RemoveResourceCommand request, CancellationToken cancellationToken) {
        WarehouseResource resource = await GetValidResource(request.Id, cancellationToken);

        _dbContext.WarehouseResources.Remove(resource);
        await _dbContext.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}
