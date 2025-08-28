using MediatR;
using WarehouseManagement.Application.Common.CQRS;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.MeasurementUnits.Commands.UpdateMeasurementUnit;

public class UpdateMeasurementUnitCommand : ICommand<Unit> {
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public WorkingState? State { get; set; }
}
