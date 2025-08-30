using FluentValidation;

namespace WarehouseManagement.Application.MeasurementUnits.Queries.GetMeasurementUnit;

public class GetMeasurementUnitQueryValidator : AbstractValidator<GetMeasurementUnitQuery>
{
    public GetMeasurementUnitQueryValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}