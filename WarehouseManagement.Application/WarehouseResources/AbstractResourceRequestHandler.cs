using MediatR;
using WarehouseManagement.Application.Common.Exceptions;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.WarehouseResources;

public abstract class AbstractResourceRequestHandler<TRequest, TResponse>(IWarehouseDbContext dbContext) : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse> {
    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);

    public async Task<WarehouseResource> GetValidResource(Guid id, CancellationToken cancellationToken) {
        WarehouseResource? resource = await dbContext.WarehouseResources.FindAsync([id], cancellationToken);
        if (resource == null) {
            throw new ResourceNotFoundException();
        }
        return resource;
    }
}
