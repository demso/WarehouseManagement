using WarehouseManagement.Application.Common.CQRS;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.MeasurementUnits.Queries.GetAllMeasurementUnits;

public class GetAllMeasurementUnitsQuery : IQuery<IEnumerable<MeasurementUnit>>
{
    public WorkingState State { get; set; }
}
