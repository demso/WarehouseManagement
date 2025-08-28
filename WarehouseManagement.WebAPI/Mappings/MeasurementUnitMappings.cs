using AutoMapper;
using WarehouseManagement.Application.MeasurementUnits.Commands.CreateMeasurementUnit;
using WarehouseManagement.Application.MeasurementUnits.Commands.UpdateMeasurementUnit;
using WarehouseManagement.Contracts.Models.MeasurementUnit;
using WarehouseManagement.Domain;
using WarehouseManagement.WebAPI.Models.MeasurementUnit;

namespace WarehouseManagement.WebAPI.Mappings;

public class MeasurementUnitMappings : Profile {
    protected MeasurementUnitMappings() {
        CreateMap<MeasurementUnit, MeasurementUnitDto>();
        CreateMap<CreateMeasurementUnitDto, CreateMeasurementUnitCommand>();
        CreateMap<UpdateMeasurementUnitDto, UpdateMeasurementUnitCommand>();
    }
}
