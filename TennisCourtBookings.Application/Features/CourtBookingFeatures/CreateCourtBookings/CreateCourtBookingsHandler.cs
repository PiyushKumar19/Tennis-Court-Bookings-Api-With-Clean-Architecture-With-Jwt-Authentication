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

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.CreateCourtBookings
{
    public sealed class CreateCourtBookingsHandler : IRequestHandler<CreateCourtBookingsRequest, CreateCourtBookingsResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICourtBookingsRepository _courtRepository;
        private readonly IMapper _mapper;

        public CreateCourtBookingsHandler(IUnitOfWork unitOfWork, ICourtBookingsRepository courtRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _courtRepository = courtRepository;
            _mapper = mapper;
        }

        public async Task<CreateCourtBookingsResponse> Handle(CreateCourtBookingsRequest request, CancellationToken cancellationToken)
        {
            var court = _mapper.Map<CourtBookings>(request);
            _courtRepository.Create(court);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<CreateCourtBookingsResponse>(court);
        }
    }
}
