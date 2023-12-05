using MediatR;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.GetAllCourtBookings;

public sealed record GetAllCourtBookingsRequest : IRequest<List<GetAllCourtBookingsResponse>>;