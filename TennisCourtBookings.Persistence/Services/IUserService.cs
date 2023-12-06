using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Application.Repositories;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Persistence.Services
{
    public interface IUserService
    {
        string GetMyName();
    }
}
