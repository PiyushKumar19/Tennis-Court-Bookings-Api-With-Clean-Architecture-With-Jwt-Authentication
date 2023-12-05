using AutoMapper;
using TennisCourtBookings.Application.Repositories;
using MediatR;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.GetAllTennisCourt;

public sealed class GetAllTennisCourtHandler : IRequestHandler<GetAllTennisCourtRequest, List<GetAllTennisCourtResponse>>
{
    private readonly ITennisCourtRepository _courtRepository;
    private readonly IMapper _mapper;

    public GetAllTennisCourtHandler(ITennisCourtRepository courtRepository, IMapper mapper)
    {
        _courtRepository = courtRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllTennisCourtResponse>> Handle(GetAllTennisCourtRequest request, CancellationToken cancellationToken)
    {
        var users = await _courtRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllTennisCourtResponse>>(users);
    }
}