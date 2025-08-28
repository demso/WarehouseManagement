using WarehouseManagement.Application.Common.CQRS;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.WarehouseResources.Commands.CreateResource;

public class CreateResourceCommand : ICommand<Guid> {
    public required string Name { get; set; }
    public required WorkingState WorkingState { get; set; }
}
