namespace Satellite.Api.DTOs.Data;

/// <summary>
/// Represents dataset metadata.
/// </summary>
public sealed class DatasetMetadataDto
{
    public Guid DatasetId { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int BandCount { get; set; }

    public string CoordinateReferenceSystem { get; set; } = string.Empty;

    public double Resolution { get; set; }

    public double MinLatitude { get; set; }

    public double MaxLatitude { get; set; }

    public double MinLongitude { get; set; }

    public double MaxLongitude { get; set; }

    public DateTime AcquisitionDate { get; set; }
}
