using ApiProject.Application.Features.Auth.Command.Login;
using ApiProject.Application.Features.Auth.Command.RefreshToken;
using ApiProject.Application.Features.Auth.Command.Register;
using ApiProject.Application.Features.Auth.Command.Revoke;
using ApiProject.Application.Features.Auth.Command.RevokeAll;
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

        public async Task<IActionResult> Register(RegisterCommandRequest request)
        {
            await mediator.Send(request);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginCommandRequest request)
        {
            var response=await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK,response);
        }

        [HttpPost]
        public async Task<IActionResult> RefrehToken(RefreshTokenCommandRequest request)
        {
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }


        [HttpPost]
        public async Task<IActionResult> Revoke(RevokeCommandRequest request)
        {
           await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpPost]
        public async Task<IActionResult> RevokeAll()
        {
            await mediator.Send(new RevokeAllCommandRequest());
            return StatusCode(StatusCodes.Status200OK);
        }






    }
}
