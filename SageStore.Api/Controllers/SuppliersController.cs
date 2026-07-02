using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SageStore.Application.CQRS.SupplierManagement.Commands;

namespace SageStore.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuppliersController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post(CreateSupplierCommand command)
    {
        await mediator.Send(command);
        return Created();
    }
}
