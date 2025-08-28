using AutoMapper;
using WarehouseManagement.Domain;

namespace WarehouseManagement.WebAPI.Models.WarehouseResource;

[AutoMap(typeof(Domain.WarehouseResource))]
public class ResourceDto {
    public required string Name { get; set; }
    public required WorkingState State { get; set; }
}
