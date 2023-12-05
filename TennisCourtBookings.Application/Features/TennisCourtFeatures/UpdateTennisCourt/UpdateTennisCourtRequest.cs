using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.UpdateTennisCourt
{
    public sealed record UpdateTennisCourtRequest(Guid Id, string Name, string Address) : IRequest<UpdateTennisCourtResponse>;

}
