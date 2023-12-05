namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.GetAllCourtBookings;

public sealed record GetAllCourtBookingsResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime BookedDate { get; set; }
}