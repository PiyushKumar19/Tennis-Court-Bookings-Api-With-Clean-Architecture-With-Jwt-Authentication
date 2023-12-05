using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.UserFeatures.UpdateUser
{
    public sealed record UpdateUserRequest(Guid Id, string Email, string Name) : IRequest<UpdateUserResponse>;

}
