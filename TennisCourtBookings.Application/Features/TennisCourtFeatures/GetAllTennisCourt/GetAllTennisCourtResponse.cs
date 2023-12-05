namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.GetAllTennisCourt;

public sealed record GetAllTennisCourtResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}