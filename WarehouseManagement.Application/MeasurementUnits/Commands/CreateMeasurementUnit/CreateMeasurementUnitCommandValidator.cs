using FluentValidation;

namespace WarehouseManagement.Application.MeasurementUnits.Commands.CreateMeasurementUnit;

public class CreateMeasurementUnitCommandValidator : AbstractValidator<CreateMeasurementUnitCommand> {
    public CreateMeasurementUnitCommandValidator() {
        RuleFor(x => x.Name).NotEmpty();
    }
}
