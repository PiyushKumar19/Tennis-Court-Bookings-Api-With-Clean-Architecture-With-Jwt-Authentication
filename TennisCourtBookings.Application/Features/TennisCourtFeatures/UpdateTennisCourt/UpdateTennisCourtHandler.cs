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

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.UpdateTennisCourt
{
    public sealed class UpdateTennisCourtHandler : IRequestHandler<UpdateTennisCourtRequest, UpdateTennisCourtResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITennisCourtRepository courtRepository;
        private readonly IMapper _mapper;

        public UpdateTennisCourtHandler(IUnitOfWork unitOfWork, ITennisCourtRepository courtRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.courtRepository = courtRepository;
            _mapper = mapper;
        }

        public async Task<UpdateTennisCourtResponse> Handle(UpdateTennisCourtRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<TennisCourt>(request);
            courtRepository.UpdateTennisCourt(user, cancellationToken);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<UpdateTennisCourtResponse>(user);
        }
    }
}
