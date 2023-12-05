using AutoMapper;
using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using TennisCourtBookings.Application.Repositories;
using TennisCourtBookings.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.UserFeatures.UpdateUser
{
    public sealed class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            _userRepository.UpdateUser(user, cancellationToken);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<UpdateUserResponse>(user);
        }
    }
}
