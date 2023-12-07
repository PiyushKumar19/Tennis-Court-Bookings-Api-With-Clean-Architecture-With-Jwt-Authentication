using AutoMapper;
using TennisCourtBookings.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.UpdateCourtBookings
{
    public sealed class UpdateCourtBookingsMapper : Profile
    {
        public UpdateCourtBookingsMapper()
        {
            CreateMap<UpdateCourtBookingsRequest, CourtBookings>();
            CreateMap<CourtBookings, UpdateCourtBookingsResponse>();
        }
    }
}
