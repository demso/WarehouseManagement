using WarehouseManagement.Domain;

namespace WarehouseManagement.Contracts.Models.WarehouseResource;

public class UpdateResourceDto {
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public WorkingState? State { get; set; }
}
