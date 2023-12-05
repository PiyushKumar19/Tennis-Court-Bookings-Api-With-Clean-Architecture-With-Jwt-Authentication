using AutoMapper;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Features.UserFeatures.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
    }
}