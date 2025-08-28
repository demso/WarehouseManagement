using MediatR;
using WarehouseManagement.Application.Common.CQRS;

namespace WarehouseManagement.Application.MeasurementUnits.Commands.RemoveMeasurementUnit;

public class RemoveMeasurementUnitCommand : ICommand<Unit> {
    public Guid Id { get; set; }
}
