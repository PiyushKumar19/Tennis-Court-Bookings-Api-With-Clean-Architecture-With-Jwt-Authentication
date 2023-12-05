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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }

        public Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }

        public User UpdateUser(User model, CancellationToken cancellationToken)
        {
            var user = Context.Users.FirstOrDefault(x => x.Id == model.Id);
            user.Email = model.Email;
            user.Name = model.Name;
            user.DateUpdated = DateTime.Now;

            Context.Update(user);
            return user;
        }

        public Guid DeleteUser(User model, CancellationToken cancellationToken)
        {
            var user = Context.Users.FirstOrDefault(x => x.Id == model.Id);
            if (user != null)
            {
                Context.Remove(user);
            }
            return user.Id;
        }
    }
}
