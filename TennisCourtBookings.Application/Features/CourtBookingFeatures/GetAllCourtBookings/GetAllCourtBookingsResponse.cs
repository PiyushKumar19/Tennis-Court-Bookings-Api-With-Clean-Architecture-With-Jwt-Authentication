namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.GetAllCourtBookings;

public sealed record GetAllCourtBookingsResponse
{
    public Guid Id { get; set; }
    public Guid CourtId { get; set; }
    public string CourtName { get; set; }
    public float Price { get; set; }
    public DateTime BookedDate { get; set; }
}