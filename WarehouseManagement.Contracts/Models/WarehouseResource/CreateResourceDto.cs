using WarehouseManagement.Domain;

namespace WarehouseManagement.Contracts.Models.WarehouseResource;

public class CreateResourceDto {
    public required string Name { get; set; }
    public required WorkingState State { get; set; }
}
