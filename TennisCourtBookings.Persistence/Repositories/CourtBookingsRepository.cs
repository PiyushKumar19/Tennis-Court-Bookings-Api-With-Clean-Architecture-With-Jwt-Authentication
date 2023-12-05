using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Application.Repositories;
using TennisCourtBookings.Domain.Entities;
using TennisCourtBookings.Persistence.Context;

namespace TennisCourtBookings.Persistence.Repositories
{
    public class CourtBookingsRepository : BaseRepository<CourtBookings>, ICourtBookingsRepository
    {
        public CourtBookingsRepository(DataContext context) : base(context)
        {
        }

        public Task<CourtBookings> GetById(Guid Id, CancellationToken cancellationToken)
        {
            return Context.CourtBookings.FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
        }

        public CourtBookings UpdateCourtBookings(CourtBookings model, CancellationToken cancellationToken)
        {
            var booking = Context.CourtBookings.FirstOrDefault(x => x.Id == model.Id);
            booking.CourtId = model.CourtId;
            booking.CourtName = model.CourtName;
            booking.BookedDate = model.BookedDate;
            booking.DateUpdated = DateTime.Now;

            Context.Update(booking);
            return booking;
        }

        public Guid DeleteCourtBookings(CourtBookings model, CancellationToken cancellationToken)
        {
            var booking = Context.CourtBookings.FirstOrDefault(x => x.Id == model.Id);
            if (booking != null)
            {
                Context.Remove(booking);
            }
            return booking.Id;
        }
    }
}
