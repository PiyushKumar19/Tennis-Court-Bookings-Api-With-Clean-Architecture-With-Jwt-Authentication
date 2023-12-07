using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.UpdateCourtBookings
{
    public sealed record UpdateCourtBookingsRequest(Guid Id, Guid CourtId, string CourtName, DateTime BookedDate, float Price) : IRequest<UpdateCourtBookingsResponse>;

}
