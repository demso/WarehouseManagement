using WarehouseManagement.Domain;

namespace WarehouseManagement.Contracts.Models.MeasurementUnit;

public class UpdateMeasurementUnitDto {
    public string? Name { get; set; }
    public WorkingState? State { get; set; }
}
