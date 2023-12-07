using AutoMapper;
using TennisCourtBookings.Application.Features.UserFeatures.GetAllUser;
using TennisCourtBookings.Application.Repositories;
using TennisCourtBookings.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.DeleteCourtBookings
{
    public sealed class DeleteCourtBookingsHandler : IRequestHandler<DeleteCourtBookingsRequest, DeleteCourtBookingsResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICourtBookingsRepository _courtRepository;
        private readonly IMapper _mapper;

        public DeleteCourtBookingsHandler(IUnitOfWork unitOfWork, ICourtBookingsRepository courtRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _courtRepository = courtRepository;
            _mapper = mapper;
        }

        public async Task<DeleteCourtBookingsResponse> Handle(DeleteCourtBookingsRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<CourtBookings>(request);
            _courtRepository.DeleteCourtBookings(user, cancellationToken);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<DeleteCourtBookingsResponse>(user);
        }
    }
}
