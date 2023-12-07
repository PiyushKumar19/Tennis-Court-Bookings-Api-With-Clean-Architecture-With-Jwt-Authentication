using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.CreateTennisCourt
{
    public sealed record CreateTennisCourtRequest(string Name, string Address) : IRequest<CreateTennisCourtResponse>;

}
