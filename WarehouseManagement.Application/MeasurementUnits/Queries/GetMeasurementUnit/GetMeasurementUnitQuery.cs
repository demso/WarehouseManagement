using WarehouseManagement.Application.Common.CQRS;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.MeasurementUnits.Queries.GetMeasurementUnit;

public class GetMeasurementUnitQuery : IQuery<MeasurementUnit>
{
    public required Guid Id { get; set; }
}