using WarehouseManagement.Domain;

namespace WarehouseManagement.Contracts.Models.MeasurementUnit;

public class MeasurementUnitDto {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public WorkingState State { get; set; }
}
