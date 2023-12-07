using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Features.UserFeatures.RegisterUser
{
    public sealed class RegisterUserMapper : Profile
    {
        public RegisterUserMapper()
        {
            CreateMap<RegisterUserRequest, User>();
            CreateMap<User, RegisterUserResponse>();
        }
    }
}
