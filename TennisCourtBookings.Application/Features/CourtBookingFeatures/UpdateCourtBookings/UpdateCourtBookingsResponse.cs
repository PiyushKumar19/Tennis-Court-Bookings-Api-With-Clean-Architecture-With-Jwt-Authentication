using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.UpdateCourtBookings
{
    public sealed record UpdateCourtBookingsResponse
    {
        public Guid Id { get; set; }
        public Guid CourtId { get; set; }
        public string CourtName { get; set; }
        public float Price { get; set; }
        public DateTime BookedDate { get; set; }
    }
}
