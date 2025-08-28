using WarehouseManagement.Application.Common.CQRS;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.MeasurementUnits.Commands.CreateMeasurementUnit;

public class CreateMeasurementUnitCommand : ICommand<Guid> {
    public required string Name { get; set; }
    public required WorkingState State { get; set; }
}
