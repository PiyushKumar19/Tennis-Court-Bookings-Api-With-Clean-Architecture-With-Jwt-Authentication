using AutoMapper;
using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using TennisCourtBookings.Application.Features.UserFeatures.GetAllUser;
using TennisCourtBookings.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.UserFeatures.DeleteUser
{
    public sealed class DeleteUserMapper : Profile
    {
        public DeleteUserMapper()
        {
            CreateMap<DeleteUserRequest, User>();
            CreateMap<User, DeleteUserResponse>();
        }
    }
}
