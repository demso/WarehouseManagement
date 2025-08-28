using WarehouseManagement.Domain;

namespace WarehouseManagement.Contracts.Models.WarehouseResource;

public class UpdateResourceDto {
    public string? Name { get; set; }
    public WorkingState? State { get; set; }
}
