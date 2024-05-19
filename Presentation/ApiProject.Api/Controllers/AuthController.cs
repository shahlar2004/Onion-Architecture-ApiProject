using ApiProject.Application.Features.Auth.Command.Register;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]

        public async Task<IActionResult> Register(RegisterCommandRequest requrst)
        {
            await mediator.Send(requrst);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
