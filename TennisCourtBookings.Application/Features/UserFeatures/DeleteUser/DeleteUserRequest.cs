﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.UserFeatures.DeleteUser
{
    public sealed record DeleteUserRequest(Guid Id) : IRequest<DeleteUserResponse>;

}
