using MediatR;
using WarehouseManagement.Application.Common.Exceptions;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.MeasurementUnits;

public abstract class AbstractMeasurementUnitRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse> {
    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);

    public async Task<MeasurementUnit> GetValidMeasurementUnit(IWarehouseDbContext dbContext, Guid id,  CancellationToken cancellationToken) {
        MeasurementUnit? unit = await dbContext.MeasurementUnits.FindAsync([id], cancellationToken);

        if (unit == null) 
            throw new MeasurementUnitNotFoundException();
        
        return unit;
    }
}