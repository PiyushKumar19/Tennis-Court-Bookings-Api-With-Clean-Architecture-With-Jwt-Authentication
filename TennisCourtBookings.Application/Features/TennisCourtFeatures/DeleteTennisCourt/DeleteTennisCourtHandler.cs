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

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.DeleteTennisCourt
{
    public sealed class DeleteTennisCourtHandler : IRequestHandler<DeleteTennisCourtRequest, DeleteTennisCourtResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITennisCourtRepository _courtRepository;
        private readonly IMapper _mapper;

        public DeleteTennisCourtHandler(IUnitOfWork unitOfWork, ITennisCourtRepository courtRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _courtRepository = courtRepository;
            _mapper = mapper;
        }

        public async Task<DeleteTennisCourtResponse> Handle(DeleteTennisCourtRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<TennisCourt>(request);
            _courtRepository.DeleteTennisCourt(user, cancellationToken);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<DeleteTennisCourtResponse>(user);
        }
    }
}
