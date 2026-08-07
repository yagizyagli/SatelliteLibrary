namespace Satellite.Api.DTOs.Satellite;

/// <summary>
/// Represents a satellite image.
/// </summary>
public sealed class SatelliteImageDto
{
    public Guid Id { get; set; }

    public string Provider { get; set; } = string.Empty;

    public string ProductId { get; set; } = string.Empty;

    public string FileName { get; set; } = string.Empty;

    public DateTime AcquisitionDate { get; set; }

    public double CloudCoverage { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public string FilePath { get; set; } = string.Empty;
}
