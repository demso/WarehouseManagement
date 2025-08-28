using AutoMapper;
using WarehouseManagement.Application.MeasurementUnits.Commands.CreateMeasurementUnit;
using WarehouseManagement.Domain;

namespace WarehouseManagement.WebAPI.Models.MeasurementUnit;

[AutoMap(typeof(CreateMeasurementUnitCommand))]
public class CreateMeasurementUnitDto {
    public required string Name { get; set; }
    public required WorkingState State { get; set; }
}
