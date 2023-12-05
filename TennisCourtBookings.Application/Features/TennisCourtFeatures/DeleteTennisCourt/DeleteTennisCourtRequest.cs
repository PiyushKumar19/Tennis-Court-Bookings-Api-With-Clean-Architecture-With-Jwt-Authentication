using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.DeleteTennisCourt
{
    public sealed record DeleteTennisCourtRequest(Guid Id) : IRequest<DeleteTennisCourtResponse>;

}
