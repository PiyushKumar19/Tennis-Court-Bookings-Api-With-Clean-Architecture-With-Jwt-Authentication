using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.CreateCourtBookings
{
    public sealed record CreateCourtBookingsResponse
    {
        public Guid CourtId { get; set; }
        public string CourtName { get; set; }
        public float Price { get; set; }
    }
}
