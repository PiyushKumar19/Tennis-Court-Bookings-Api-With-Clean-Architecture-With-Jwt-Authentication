using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.CreateCourtBookings
{
    public sealed class CreateCourtBookingsMapper : Profile
    {
        public CreateCourtBookingsMapper()
        {
            CreateMap<CreateCourtBookingsRequest, CourtBookings>();
            CreateMap<CourtBookings, CreateCourtBookingsResponse>();
        }
    }
}
