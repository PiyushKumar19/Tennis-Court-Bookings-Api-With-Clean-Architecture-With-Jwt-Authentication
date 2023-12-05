using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Repositories
{
    public interface ITennisCourtRepository : IBaseRepository<TennisCourt>
    {
        Task<TennisCourt> GetById(Guid Id, CancellationToken cancellationToken);
        TennisCourt UpdateTennisCourt(TennisCourt model, CancellationToken cancellationToken);
        Guid DeleteTennisCourt(TennisCourt model, CancellationToken cancellationToken);
    }
}
