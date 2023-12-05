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
    public class TennisCourtRepository : BaseRepository<TennisCourt>, ITennisCourtRepository
    {
        public TennisCourtRepository(DataContext context) : base(context)
        {
        }

        public Task<TennisCourt> GetById(Guid Id, CancellationToken cancellationToken)
        {
            return Context.TennisCourts.FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
        }

        public TennisCourt UpdateTennisCourt(TennisCourt model, CancellationToken cancellationToken)
        {
            var booking = Context.TennisCourts.FirstOrDefault(x => x.Id == model.Id);
            booking.Name = model.Name;
            booking.Address = model.Address;
            booking.DateUpdated = DateTime.Now;

            Context.Update(booking);
            return booking;
        }

        public Guid DeleteTennisCourt(TennisCourt model, CancellationToken cancellationToken)
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
