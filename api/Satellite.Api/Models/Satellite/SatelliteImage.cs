namespace Satellite.Api.Models.Satellite;

/// <summary>
/// Represents a downloaded satellite image.
/// </summary>
public sealed class SatelliteImage
{
    public Guid Id { get; set; }

    public Guid ProviderId { get; set; }

    public string ProductId { get; set; } = string.Empty;

    public string FileName { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;

    public string FileFormat { get; set; } = string.Empty;

    public long FileSize { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public double CloudCoverage { get; set; }

    public DateTime AcquisitionDate { get; set; }

    public DateTime DownloadedAtUtc { get; set; }

    public SatelliteProvider? Provider { get; set; }
}
