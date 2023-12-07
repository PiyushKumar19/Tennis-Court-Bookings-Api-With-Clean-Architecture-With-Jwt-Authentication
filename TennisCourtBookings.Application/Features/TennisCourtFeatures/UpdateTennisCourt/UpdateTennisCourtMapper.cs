using AutoMapper;
using TennisCourtBookings.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.UpdateTennisCourt
{
    public sealed class UpdateTennisCourtMapper : Profile
    {
        public UpdateTennisCourtMapper()
        {
            CreateMap<UpdateTennisCourtRequest, TennisCourt>();
            CreateMap<TennisCourt, UpdateTennisCourtResponse>();
        }
    }
}
