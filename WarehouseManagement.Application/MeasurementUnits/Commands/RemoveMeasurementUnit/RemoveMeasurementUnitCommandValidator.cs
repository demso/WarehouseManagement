using FluentValidation;

namespace WarehouseManagement.Application.MeasurementUnits.Commands.RemoveMeasurementUnit;

public class RemoveMeasurementUnitCommandValidator : AbstractValidator<RemoveMeasurementUnitCommand> {
    public RemoveMeasurementUnitCommandValidator() {
        RuleFor(x => x.Id).NotEmpty();
    }
}
