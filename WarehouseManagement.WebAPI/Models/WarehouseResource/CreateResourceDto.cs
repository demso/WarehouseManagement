using AutoMapper;
using WarehouseManagement.Application.WarehouseResources.Commands.CreateResource;
using WarehouseManagement.Domain;

namespace WarehouseManagement.WebAPI.Models.WarehouseResource;

[AutoMap(typeof(CreateResourceCommand))]
public class CreateResourceDto {
    public required string Name { get; set; }
    public required WorkingState State { get; set; }
}
