using MediatR;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.WarehouseResources.Commands.UpdateResource;

public class UpdateResourceCommandHandler(IWarehouseDbContext dbContext) : AbstractResourceRequestHandler<UpdateResourceCommand, Unit>(dbContext) {
    private readonly IWarehouseDbContext _dbContext = dbContext;

    public override async Task<Unit> Handle(UpdateResourceCommand request, CancellationToken cancellationToken) {
        WarehouseResource resource = await GetValidResource(request.Id, cancellationToken);
        
        if (request.Name == resource.Name && request.State == resource.State)
            return Unit.Value;
        
        if (request.Name is not null)
            resource.Name = request.Name;
        if (request.State is not null)
            resource.State = request.State.Value;
        
        // объект отслеживается, поэтому просто сохраняем изменения
        await _dbContext.SaveChangesAsync(cancellationToken); 
        
        return Unit.Value;
    }
}
