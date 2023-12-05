using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.UpdateCourtBookings
{
    public sealed record UpdateCourtBookingsResponse
    {
        public Guid CourtId { get; set; }
        public string Name { get; set; }
    }
}
