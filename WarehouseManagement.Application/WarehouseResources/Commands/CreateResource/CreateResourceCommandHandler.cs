using MediatR;
using WarehouseManagement.Application.Interfaces;

namespace WarehouseManagement.Application.WarehouseResources.Commands.CreateResource;

public class CreateResourceCommandHandler(IWarehouseDbContext dbContext) : IRequestHandler<CreateResourceCommand, Guid> {
    public async Task<Guid> Handle(CreateResourceCommand request, CancellationToken cancellationToken) {

        Domain.WarehouseResource warehouseResource = new Domain.WarehouseResource {
            Name = request.Name,
            State = request.WorkingState,
        };
        
        await dbContext.WarehouseResources.AddAsync(warehouseResource, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
        
        return warehouseResource.Id;
    }
}
