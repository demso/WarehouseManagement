using FluentValidation;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.WarehouseResources.Commands.UpdateResource;
/// <summary>
/// Используется для изменения описания ресурса или изменения состояния ресурса (<see cref="WarehouseResource"/>)
/// </summary>
public class UpdateResourceCommandValidator : AbstractValidator<UpdateResourceCommand>{
    /// <summary>
    /// Имя или состояние должны быть указаны в команде обновления ресурса
    /// </summary>
    public UpdateResourceCommandValidator() {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name or WorkingState is required for update")
            .When(x => x.State is null);
        RuleFor(x => x.Name)
            .NotEmpty()
            .When(x => x.Name is not null);
    }
}
