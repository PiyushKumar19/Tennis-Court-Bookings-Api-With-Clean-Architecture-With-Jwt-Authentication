using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Domain.Common.Entities;

namespace TennisCourtBookings.Domain.Entities
{
    public sealed class CourtBookings : BaseEntity
    {
        public Guid CourtId { get; set; }
        public string CourtName { get; set; }
        public DateTime BookedDate { get; set; }
        public float Price { get; set; }
    }
}
