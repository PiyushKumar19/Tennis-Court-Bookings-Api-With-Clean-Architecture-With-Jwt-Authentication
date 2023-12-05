using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(string email, CancellationToken cancellationToken);
        User UpdateUser(User model, CancellationToken cancellationToken);
        Guid DeleteUser(User model, CancellationToken cancellationToken);
    }
}
