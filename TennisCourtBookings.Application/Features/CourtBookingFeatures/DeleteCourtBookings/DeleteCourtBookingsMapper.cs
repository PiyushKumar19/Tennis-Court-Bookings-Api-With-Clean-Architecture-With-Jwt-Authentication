using AutoMapper;
using TennisCourtBookings.Application.Features.UserFeatures.GetAllUser;
using TennisCourtBookings.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.DeleteCourtBookings
{
    public sealed class DeleteCourtBookingsMapper : Profile
    {
        public DeleteCourtBookingsMapper()
        {
            CreateMap<DeleteCourtBookingsRequest, CourtBookings>();
            CreateMap<CourtBookings, DeleteCourtBookingsResponse>();
        }
    }
}
