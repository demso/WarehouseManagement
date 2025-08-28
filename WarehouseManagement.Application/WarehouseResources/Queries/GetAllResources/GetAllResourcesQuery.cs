using WarehouseManagement.Application.Common.CQRS;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Application.WarehouseResources.Queries.GetAllResources;

public class GetAllResourcesQuery : ICommand<IEnumerable<WarehouseResource>> {
    public WorkingState State { get; set; }
};
