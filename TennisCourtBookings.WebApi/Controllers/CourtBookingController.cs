using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TennisCourtBookings.Application.Features.CourtBookingsFeatures.CreateCourtBookings;
using TennisCourtBookings.Application.Features.CourtBookingsFeatures.DeleteCourtBookings;
using TennisCourtBookings.Application.Features.CourtBookingsFeatures.GetAllCourtBookings;
using TennisCourtBookings.Application.Features.CourtBookingsFeatures.UpdateCourtBookings;
using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using TennisCourtBookings.Application.Features.UserFeatures.DeleteUser;
using TennisCourtBookings.Application.Features.UserFeatures.GetAllUser;
using TennisCourtBookings.Application.Features.UserFeatures.UpdateUser;

namespace TennisCourtBookings.WebApi.Controllers
{
    [ApiController]
    [Route("CourtBooking")]
    public class CourtBookingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CourtBookingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllBookings")]
        public async Task<ActionResult<List<GetAllCourtBookingsResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllCourtBookingsRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost("NewBooking")]
        public async Task<ActionResult<CreateCourtBookingsResponse>> Create(CreateCourtBookingsRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPut("UpdateBooking")]
        public async Task<ActionResult<UpdateCourtBookingsResponse>> Update(UpdateCourtBookingsRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete("UpdateBooking")]
        public async Task<ActionResult<DeleteCourtBookingsResponse>> Delete(DeleteCourtBookingsRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
