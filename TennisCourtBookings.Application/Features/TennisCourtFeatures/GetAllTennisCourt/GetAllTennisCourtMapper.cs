using AutoMapper;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.GetAllTennisCourt;

public sealed class GetAllTennisCourtMapper : Profile
{
    public GetAllTennisCourtMapper()
    {
        CreateMap<TennisCourt, GetAllTennisCourtResponse>();
    }
}