using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Repositories
{
    public interface ICourtBookingsRepository : IBaseRepository<CourtBookings>
    {
        Task<CourtBookings> GetById(Guid Id, CancellationToken cancellationToken);
        CourtBookings UpdateCourtBookings(CourtBookings model, CancellationToken cancellationToken);
        Guid DeleteCourtBookings(CourtBookings model, CancellationToken cancellationToken);
    }
}
