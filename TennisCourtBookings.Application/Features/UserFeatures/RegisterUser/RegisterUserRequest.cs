using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;

namespace TennisCourtBookings.Application.Features.UserFeatures.RegisterUser
{
    public sealed record RegisterUserRequest(string Email, string Username, string Password ) : IRequest<RegisterUserResponse>;

}
