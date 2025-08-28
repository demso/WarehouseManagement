using WarehouseManagement.Domain;

namespace WarehouseManagement.Contracts.Models.WarehouseResource;

public class WarehouseResourceDto {
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required WorkingState State { get; set; }
}
