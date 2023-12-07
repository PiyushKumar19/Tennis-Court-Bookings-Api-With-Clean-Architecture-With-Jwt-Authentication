using AutoMapper;
using TennisCourtBookings.Application.Repositories;
using TennisCourtBookings.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.UpdateCourtBookings
{
    public sealed class UpdateCourtBookingsHandler : IRequestHandler<UpdateCourtBookingsRequest, UpdateCourtBookingsResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICourtBookingsRepository courtRepository;
        private readonly IMapper _mapper;

        public UpdateCourtBookingsHandler(IUnitOfWork unitOfWork, ICourtBookingsRepository courtRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.courtRepository = courtRepository;
            _mapper = mapper;
        }

        public async Task<UpdateCourtBookingsResponse> Handle(UpdateCourtBookingsRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<CourtBookings>(request);
            courtRepository.UpdateCourtBookings(user, cancellationToken);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<UpdateCourtBookingsResponse>(user);
        }
    }
}
