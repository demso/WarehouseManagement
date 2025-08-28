using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WarehouseManagement.WebAPI.Controllers;

[ApiController]
public class AbstractController : ControllerBase {
    protected IMediator Mediator => HttpContext.RequestServices.GetRequiredService<IMediator>();
    protected IMapper Mapper => HttpContext.RequestServices.GetRequiredService<IMapper>();
}
