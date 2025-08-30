using Microsoft.AspNetCore.Mvc;
using WarehouseManagement.Application.MeasurementUnits.Commands.CreateMeasurementUnit;
using WarehouseManagement.Application.MeasurementUnits.Commands.RemoveMeasurementUnit;
using WarehouseManagement.Application.MeasurementUnits.Commands.UpdateMeasurementUnit;
using WarehouseManagement.Application.MeasurementUnits.Queries.GetAllMeasurementUnits;
using WarehouseManagement.Application.MeasurementUnits.Queries.GetMeasurementUnit;
using WarehouseManagement.Contracts.Models.MeasurementUnit;
using WarehouseManagement.Domain;

namespace WarehouseManagement.WebAPI.Controllers;

[Route("/api/[controller]/[action]")]
[Produces("application/json")]
public class MeasurementUnitController : AbstractController
{
    /// <summary>
    /// Возвращает информацию обо всех имеющихся ресурсах на складе
    /// </summary>
    /// <returns>Список ресурсов</returns>
    [HttpGet("{state}")]
    public async Task<ActionResult<IEnumerable<MeasurementUnit>>> GetAll(string state)
    {
        WorkingState workingState = Enum.Parse<WorkingState>(state, true);
        GetAllMeasurementUnitsQuery command = new()
        {
            State = workingState
        };
        IEnumerable<MeasurementUnit> result = await Mediator.Send(command);
        return Ok(result);
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<IEnumerable<MeasurementUnit>>> Get(Guid id)
    {
        GetMeasurementUnitQuery command = new()
        {
            Id = id
        };
        MeasurementUnit result = await Mediator.Send(command);
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> Add([FromBody] CreateMeasurementUnitDto dto)
    {
        CreateMeasurementUnitCommand? command = Mapper.Map<CreateMeasurementUnitCommand>(dto);
        Guid result = await Mediator.Send(command);
        return Ok(result);
    }

    [HttpPatch("{id:Guid}")]
    public async Task<ActionResult<Guid>> Update(Guid id, [FromBody] UpdateMeasurementUnitDto dto)
    {
        UpdateMeasurementUnitCommand? command = Mapper.Map<UpdateMeasurementUnitCommand>(dto);
        await Mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("{id:Guid}")]
    public async Task<ActionResult<Guid>> Delete(Guid id)
    {
        RemoveMeasurementUnitCommand command = new() { Id = id };
        await Mediator.Send(command);
        return NoContent();
    }
}