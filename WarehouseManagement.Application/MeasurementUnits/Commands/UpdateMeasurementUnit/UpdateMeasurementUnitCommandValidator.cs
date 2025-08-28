using FluentValidation;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.MeasurementUnits.Commands.UpdateMeasurementUnit;

/// <summary>
/// Используется для изменения наименования или состояния единицы измерения (<see cref="MeasurementUnit"/>)
/// </summary>
public class UpdateMeasurementUnitCommandValidator  : AbstractValidator<UpdateMeasurementUnitCommand> {
    /// <summary>
    /// Имя или состояние должны быть указаны в команде обновления единицы измерения
    /// </summary>
    public UpdateMeasurementUnitCommandValidator() {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name or WorkingState is required for update")
            .When(x => x.State is null);
    }
}
