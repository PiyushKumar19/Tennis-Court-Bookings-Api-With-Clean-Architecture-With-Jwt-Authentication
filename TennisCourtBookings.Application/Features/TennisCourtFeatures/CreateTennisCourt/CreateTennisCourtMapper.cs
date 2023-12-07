using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.CreateTennisCourt
{
    public sealed class CreateTennisCourtMapper : Profile
    {
        public CreateTennisCourtMapper()
        {
            CreateMap<CreateTennisCourtRequest, TennisCourt>();
            CreateMap<TennisCourt, CreateTennisCourtResponse>();
        }
    }
}
