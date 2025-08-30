using Microsoft.EntityFrameworkCore;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.MeasurementUnits.Queries.GetAllMeasurementUnits;

public class GetAllMeasurementUnitsQueryHandler(IWarehouseDbContext dbContext)
    : AbstractMeasurementUnitRequestHandler<GetAllMeasurementUnitsQuery, IEnumerable<MeasurementUnit>>
{
    public override async Task<IEnumerable<MeasurementUnit>> Handle(GetAllMeasurementUnitsQuery request,
        CancellationToken cancellationToken)
    {
        List<MeasurementUnit> measurementUnits = await dbContext.MeasurementUnits
            .Where(x => x.State.Equals(request.State))
            .ToListAsync(cancellationToken);
        
        return measurementUnits;
    }
}
