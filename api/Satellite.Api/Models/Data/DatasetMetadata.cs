namespace Satellite.Api.Models.Data;

/// <summary>
/// Represents dataset metadata.
/// </summary>
public sealed class DatasetMetadata
{
    public Guid DatasetId { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int BandCount { get; set; }

    public string CoordinateReferenceSystem { get; set; } = string.Empty;

    public double Resolution { get; set; }

    public DateTime AcquisitionDate { get; set; }
}
