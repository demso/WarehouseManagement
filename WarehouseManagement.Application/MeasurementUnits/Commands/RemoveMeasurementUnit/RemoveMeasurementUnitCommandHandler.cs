using MediatR;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.MeasurementUnits.Commands.RemoveMeasurementUnit;

public class RemoveMeasurementUnitCommandHandler(IWarehouseDbContext dbContext) : AbstractMeasurementUnitRequestHandler<RemoveMeasurementUnitCommand, Unit> {
    public override async Task<Unit> Handle(RemoveMeasurementUnitCommand request, CancellationToken cancellationToken) {
        MeasurementUnit unit = await GetValidMeasurementUnit(dbContext, request.Id, cancellationToken);
        
        dbContext.MeasurementUnits.Remove(unit);
        await dbContext.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}
