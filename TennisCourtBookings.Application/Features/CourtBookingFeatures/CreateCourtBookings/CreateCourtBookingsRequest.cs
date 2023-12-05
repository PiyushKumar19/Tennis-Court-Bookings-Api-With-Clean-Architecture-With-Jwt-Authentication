using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.CreateCourtBookings
{
    public sealed record CreateCourtBookingsRequest(Guid CourtId, string CourtName, float Price, DateTime BookingDate) : IRequest<CreateCourtBookingsResponse>;

}
