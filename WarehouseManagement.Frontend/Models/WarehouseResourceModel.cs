using WarehouseManagement.Domain;

namespace WarehouseManagement.Frontend.Models;

public class WarehouseResourceModel
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required WorkingState State { get; set; }
}