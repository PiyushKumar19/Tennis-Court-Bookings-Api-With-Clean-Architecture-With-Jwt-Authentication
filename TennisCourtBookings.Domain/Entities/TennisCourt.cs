using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Domain.Common.Entities;

namespace TennisCourtBookings.Domain.Entities
{
    public sealed class TennisCourt : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
