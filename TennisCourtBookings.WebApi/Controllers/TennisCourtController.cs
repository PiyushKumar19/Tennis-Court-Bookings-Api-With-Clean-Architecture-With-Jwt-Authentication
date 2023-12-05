using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TennisCourtBookings.Application.Features.TennisCourtFeatures.CreateTennisCourt;
using TennisCourtBookings.Application.Features.TennisCourtFeatures.DeleteTennisCourt;
using TennisCourtBookings.Application.Features.TennisCourtFeatures.GetAllTennisCourt;
using TennisCourtBookings.Application.Features.TennisCourtFeatures.UpdateTennisCourt;
using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using TennisCourtBookings.Application.Features.UserFeatures.DeleteUser;
using TennisCourtBookings.Application.Features.UserFeatures.GetAllUser;
using TennisCourtBookings.Application.Features.UserFeatures.UpdateUser;

namespace TennisCourtBookings.WebApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class TennisCourtController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TennisCourtController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllCourts")]
        public async Task<ActionResult<List<GetAllTennisCourtResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllTennisCourtRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost("NewCourt")]
        public async Task<ActionResult<CreateTennisCourtResponse>> Create(CreateTennisCourtRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPut("UpdateCourt")]
        public async Task<ActionResult<UpdateTennisCourtResponse>> Update(UpdateTennisCourtRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete("DeleteCourt")]
        public async Task<ActionResult<DeleteTennisCourtResponse>> Delete(DeleteTennisCourtRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
