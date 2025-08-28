using FluentValidation;

namespace WarehouseManagement.Application.WarehouseResources.Commands.CreateResource;

public class CreateResourceCommandValidator : AbstractValidator<CreateResourceCommand> {
    public CreateResourceCommandValidator() {
        RuleFor(x => x.Name).NotEmpty();
    }
}
