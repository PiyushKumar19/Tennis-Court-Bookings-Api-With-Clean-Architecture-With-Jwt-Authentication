using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using TennisCourtBookings.Application.Features.UserFeatures.DeleteUser;
using TennisCourtBookings.Application.Features.UserFeatures.GetAllUser;
using TennisCourtBookings.Application.Features.UserFeatures.LoginUser;
using TennisCourtBookings.Application.Features.UserFeatures.RegisterUser;
using TennisCourtBookings.Application.Features.UserFeatures.UpdateUser;
using TennisCourtBookings.Domain.Entities;
using TennisCourtBookings.Persistence.Services;

namespace TennisCourtBookings.WebApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        //public static User user = new User();
        private readonly IConfiguration configuration;
        private readonly IUserService userService;
        private readonly IMediator _mediator;

        public UserController(IMediator mediator, IUserService userService, IConfiguration configuration)
        {
            _mediator = mediator;
            this.userService = userService;
            this.configuration = configuration;
        }

        [HttpGet, Authorize]
        public ActionResult<string> GetMe()
        {
            var username = userService.GetMyName();

            //var userName = User?.Identity?.Name;
            //var userName2 = User?.FindFirstValue(ClaimTypes.Name);
            var role = User?.FindFirstValue(ClaimTypes.Role);
            return Ok(new { username, role });
        }

        [HttpPost("register")]
        public async Task<ActionResult<RegisterUserResponse>> Register(RegisterUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _mediator.Send(request, cancellationToken);

            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginUserResponse>> Login(LoginUserRequest request, CancellationToken cancellationToken)
        {
            var token = await _mediator.Send(request, cancellationToken);
            return Ok(token);
        }
        

        [HttpGet("GetAllUsers"), Authorize]
        public async Task<ActionResult<List<GetAllUserResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllUserRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost("createUser")]
        public async Task<ActionResult<CreateUserResponse>> Create(CreateUserRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPut("UpdateUser")]
        public async Task<ActionResult<UpdateUserResponse>> Update(UpdateUserRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete("DeleteUser")]
        public async Task<ActionResult<DeleteUserResponse>> Delete(DeleteUserRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
