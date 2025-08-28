using AutoMapper;
using WarehouseManagement.Domain;

namespace WarehouseManagement.WebAPI.Models.MeasurementUnit;

[AutoMap(typeof(Domain.MeasurementUnit))]
public class MeasurementUnitDto {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public WorkingState State { get; set; }
}
