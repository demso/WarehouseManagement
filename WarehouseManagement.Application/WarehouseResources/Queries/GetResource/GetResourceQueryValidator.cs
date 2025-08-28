using FluentValidation;

namespace WarehouseManagement.Application.WarehouseResources.Queries.GetResource;

public class GetResourceQueryValidator  : AbstractValidator<GetResourceQuery> {
    public GetResourceQueryValidator() {
        RuleFor(x => x.Id).NotEmpty();
    }
}
