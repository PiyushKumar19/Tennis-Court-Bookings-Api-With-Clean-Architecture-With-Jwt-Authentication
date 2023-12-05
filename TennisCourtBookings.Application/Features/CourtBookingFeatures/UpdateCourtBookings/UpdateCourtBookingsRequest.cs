using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.UpdateCourtBookings
{
    public sealed record UpdateCourtBookingsRequest(Guid CourtId, string Name) : IRequest<UpdateCourtBookingsResponse>;

}
