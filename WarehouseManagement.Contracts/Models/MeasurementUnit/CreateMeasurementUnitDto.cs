using WarehouseManagement.Domain;

namespace WarehouseManagement.Contracts.Models.MeasurementUnit;

public class CreateMeasurementUnitDto {
    public required string Name { get; set; }
    public required WorkingState State { get; set; }
}
