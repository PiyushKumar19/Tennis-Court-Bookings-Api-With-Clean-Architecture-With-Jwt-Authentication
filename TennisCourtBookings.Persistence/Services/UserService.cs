using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Domain.Entities;
using TennisCourtBookings.Persistence.Context;
using TennisCourtBookings.Persistence.Repositories;

namespace TennisCourtBookings.Persistence.Services
{
    public class UserService : BaseRepository<User>, IUserService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly DataContext context;

        public UserService(IHttpContextAccessor _httpContextAccessor, DataContext context) : base(context)
        {
            httpContextAccessor = _httpContextAccessor;
            this.context = context;
        }

        public string GetMyName()
        {
            var result = string.Empty;
            if (httpContextAccessor.HttpContext != null)
            {
                result = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }
    }
}
