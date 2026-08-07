namespace Satellite.Api.DTOs.Satellite;

/// <summary>
/// Represents a supported satellite provider.
/// </summary>
public sealed class SatelliteProviderDto
{
    public string Name { get; set; } = string.Empty;

    public string DisplayName { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool IsAvailable { get; set; }
}
