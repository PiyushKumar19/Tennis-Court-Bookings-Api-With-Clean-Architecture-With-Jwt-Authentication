using AutoMapper;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.GetAllCourtBookings;

public sealed class GetAllCourtBookingsMapper : Profile
{
    public GetAllCourtBookingsMapper()
    {
        CreateMap<CourtBookings, GetAllCourtBookingsResponse>();
    }
}