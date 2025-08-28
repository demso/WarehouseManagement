using MediatR;
using WarehouseManagement.Application.Common.CQRS;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.WarehouseResources.Commands.UpdateResource;


public class UpdateResourceCommand : ICommand<Unit> {
    public required Guid Id { get; set; }
    public string? Name { get; set; }
    public WorkingState? State { get; set; }
}
