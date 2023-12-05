using MediatR;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.GetAllTennisCourt;

public sealed record GetAllTennisCourtRequest : IRequest<List<GetAllTennisCourtResponse>>;