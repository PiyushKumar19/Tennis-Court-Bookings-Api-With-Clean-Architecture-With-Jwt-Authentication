using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Application.Features.UserFeatures.RegisterUser;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Features.UserFeatures.LoginUser
{
    public sealed class LoginUserMapper : Profile
    {
        public LoginUserMapper()
        {
            CreateMap<LoginUserRequest, User>();
            CreateMap<User, LoginUserResponse>();
        }
    }
}
