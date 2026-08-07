namespace Satellite.Api.Models.Satellite;

/// <summary>
/// Represents a satellite data provider.
/// </summary>
public sealed class SatelliteProvider
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string DisplayName { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string ApiUrl { get; set; } = string.Empty;

    public bool IsAvailable { get; set; }

    public DateTime CreatedAtUtc { get; set; }
}
