using AutoMapper;
using WarehouseManagement.Application.WarehouseResources.Commands.UpdateResource;
using WarehouseManagement.Domain;

namespace WarehouseManagement.WebAPI.Models.WarehouseResource;

[AutoMap(typeof(UpdateResourceCommand))]
public class UpdateResourceDto {
    public string? Name { get; set; }
    public WorkingState? State { get; set; }
}
