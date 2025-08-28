using FluentValidation;

namespace WarehouseManagement.Application.WarehouseResources.Commands.RemoveResource;

public class RemoveResourceCommandValidator : AbstractValidator<RemoveResourceCommand> {
    public RemoveResourceCommandValidator() {
        RuleFor(x => x.Id).NotEmpty();
    }
}
