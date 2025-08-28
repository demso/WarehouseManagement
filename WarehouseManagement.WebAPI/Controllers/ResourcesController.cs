using Microsoft.AspNetCore.Mvc;
using WarehouseManagement.Application.WarehouseResources.Commands.CreateResource;
using WarehouseManagement.Application.WarehouseResources.Commands.RemoveResource;
using WarehouseManagement.Application.WarehouseResources.Commands.UpdateResource;
using WarehouseManagement.Application.WarehouseResources.Queries.GetAllResources;
using WarehouseManagement.Application.WarehouseResources.Queries.GetResource;
using WarehouseManagement.Contracts.Models.WarehouseResource;
using WarehouseManagement.Domain;

namespace WarehouseManagement.WebAPI.Controllers;

[Route("/api/[controller]/[action]")]
[Produces("application/json")]
public class ResourcesController : AbstractController {
    /// <summary>
    /// Возвращает информацию обо всех имеющихся ресурсах на складе
    /// </summary>
    /// <returns>Список ресурсов</returns>
    [HttpGet("{state}")]
    public async Task<ActionResult<IEnumerable<WarehouseResource>>> GetAll(string state) {
        WorkingState workingState = Enum.Parse<WorkingState>(state, true);
        GetAllResourcesQuery command = new() {
            State = workingState
        };
        IEnumerable<WarehouseResource> result = await Mediator.Send(command);
        return Ok(result);
    }
    
    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<IEnumerable<WarehouseResource>>> Get(Guid id) {
        GetResourceQuery command = new() {
            Id = id
        };
        WarehouseResource result = await Mediator.Send(command);
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> Add([FromBody] CreateResourceDto dto) {
        CreateResourceCommand? command = Mapper.Map<CreateResourceCommand>(dto);
        Guid result = await Mediator.Send(command);
        return Ok(result);
    }

    [HttpPatch("{id:Guid}")]
    public async Task<ActionResult<Guid>> Update(Guid id, [FromBody] UpdateResourceDto dto) {
        UpdateResourceCommand? command = Mapper.Map<UpdateResourceCommand>(dto);
        await Mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("{id:Guid}")]
    public async Task<ActionResult<Guid>> Delete(Guid id) {
        RemoveResourceCommand? command = new() { Id = id };
        await Mediator.Send(command);
        return NoContent();
    }
}
