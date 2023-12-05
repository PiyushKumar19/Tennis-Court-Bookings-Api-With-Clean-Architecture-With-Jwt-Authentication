using AutoMapper;
using TennisCourtBookings.Application.Repositories;
using MediatR;
using TennisCourtBookings.Application.Features.CourtBookingsFeatures.GetAllCourtBookings;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.GetAllCourtBookings;

public sealed class GetAllCourtBookingsHandler : IRequestHandler<GetAllCourtBookingsRequest, List<GetAllCourtBookingsResponse>>
{
    private readonly ICourtBookingsRepository _courtRepository;
    private readonly IMapper _mapper;

    public GetAllCourtBookingsHandler(ICourtBookingsRepository courtRepository, IMapper mapper)
    {
        _courtRepository = courtRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllCourtBookingsResponse>> Handle(GetAllCourtBookingsRequest request, CancellationToken cancellationToken)
    {
        var users = await _courtRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllCourtBookingsResponse>>(users);
    }
}