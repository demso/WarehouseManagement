using AutoMapper;
using WarehouseManagement.Application.MeasurementUnits.Commands.CreateMeasurementUnit;
using WarehouseManagement.Application.MeasurementUnits.Commands.UpdateMeasurementUnit;
using WarehouseManagement.Contracts.Models.MeasurementUnit;
using WarehouseManagement.Domain;

namespace WarehouseManagement.WebAPI.Mappings;

public class MeasurementUnitMappings : Profile {
    public MeasurementUnitMappings() {
        CreateMap<MeasurementUnit, MeasurementUnitDto>();
        CreateMap<CreateMeasurementUnitDto, CreateMeasurementUnitCommand>();
        CreateMap<UpdateMeasurementUnitDto, UpdateMeasurementUnitCommand>();
    }
}
