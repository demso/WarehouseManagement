using AutoMapper;
using WarehouseManagement.Application.MeasurementUnits.Commands.UpdateMeasurementUnit;
using WarehouseManagement.Domain;

namespace WarehouseManagement.WebAPI.Models.MeasurementUnit;

[AutoMap(typeof(UpdateMeasurementUnitCommand))]
public class UpdateMeasurementUnitDto {
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public WorkingState? State { get; set; }
}
