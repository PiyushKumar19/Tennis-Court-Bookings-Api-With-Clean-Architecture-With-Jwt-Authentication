using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using TennisCourtBookings.Application.Repositories;
using TennisCourtBookings.Domain.Entities;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.CreateTennisCourt
{
    public sealed class CreateTennisCourtHandler : IRequestHandler<CreateTennisCourtRequest, CreateTennisCourtResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITennisCourtRepository _courtRepository;
        private readonly IMapper _mapper;

        public CreateTennisCourtHandler(IUnitOfWork unitOfWork, ITennisCourtRepository courtRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _courtRepository = courtRepository;
            _mapper = mapper;
        }

        public async Task<CreateTennisCourtResponse> Handle(CreateTennisCourtRequest request, CancellationToken cancellationToken)
        {
            var court = _mapper.Map<TennisCourt>(request);
            _courtRepository.Create(court);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<CreateTennisCourtResponse>(court);
        }
    }
}
