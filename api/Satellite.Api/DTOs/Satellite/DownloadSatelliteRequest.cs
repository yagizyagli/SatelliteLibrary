namespace Satellite.Api.DTOs.Satellite;

/// <summary>
/// Represents a request to download satellite imagery.
/// </summary>
public sealed class DownloadSatelliteRequest
{
    public string Provider { get; set; } = string.Empty;

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public double Radius { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int MaxResults { get; set; } = 10;
}
