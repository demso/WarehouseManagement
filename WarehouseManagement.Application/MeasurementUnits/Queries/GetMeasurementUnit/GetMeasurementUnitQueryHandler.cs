using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.MeasurementUnits.Queries.GetMeasurementUnit;

public class GetMeasurementUnitQueryHandler(IWarehouseDbContext dbContext) : AbstractMeasurementUnitRequestHandler<GetMeasurementUnitQuery, MeasurementUnit>
{
    public override async Task<MeasurementUnit> Handle(GetMeasurementUnitQuery request, CancellationToken cancellationToken)
    {
        return await GetValidMeasurementUnit(dbContext, request.Id, cancellationToken);
    }
}