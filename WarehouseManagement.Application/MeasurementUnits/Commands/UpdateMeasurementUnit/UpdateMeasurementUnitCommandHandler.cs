using MediatR;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.MeasurementUnits.Commands.UpdateMeasurementUnit;

public class UpdateMeasurementUnitCommandHandler(IWarehouseDbContext dbContext) : AbstractMeasurementUnitRequestHandler<UpdateMeasurementUnitCommand, Unit> {
    public override async Task<Unit> Handle(UpdateMeasurementUnitCommand request, CancellationToken cancellationToken) {
        MeasurementUnit unit =  await GetValidMeasurementUnit(dbContext, request.Id, cancellationToken);
        
        if (request.Name == unit.Name && request.State == unit.State)
            return Unit.Value;

        if (request.Name is not null)
            unit.Name = request.Name;
        if (request.State is not null)
            unit.State = request.State.Value;
        
        await dbContext.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}
