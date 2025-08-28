using AutoMapper;
using WarehouseManagement.Application.WarehouseResources.Commands.CreateResource;
using WarehouseManagement.Application.WarehouseResources.Commands.UpdateResource;
using WarehouseManagement.Contracts.Models.WarehouseResource;
using WarehouseManagement.Domain;

namespace WarehouseManagement.WebAPI.Mappings;

public class WarehousResourceMappings : Profile {
    protected WarehousResourceMappings() {
        CreateMap<WarehouseResource, WarehouseResourceDto>();
        CreateMap<UpdateResourceDto, UpdateResourceCommand>();
        CreateMap<CreateResourceDto, CreateResourceCommand>();
    }
}
