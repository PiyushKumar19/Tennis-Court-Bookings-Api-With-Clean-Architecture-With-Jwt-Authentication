using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.UserFeatures.LoginUser
{
    public sealed record LoginUserResponse
    {
        public string Token { get; set; }
    }
}
