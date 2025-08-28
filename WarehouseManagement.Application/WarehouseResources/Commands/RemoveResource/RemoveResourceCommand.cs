using MediatR;
using WarehouseManagement.Application.Common.CQRS;

namespace WarehouseManagement.Application.WarehouseResources.Commands.RemoveResource;

public class RemoveResourceCommand : ICommand<Unit> {
    public required Guid Id { get; set; }
}
