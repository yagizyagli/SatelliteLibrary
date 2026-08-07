namespace Satellite.Api.Models.Configuration;

/// <summary>
/// Represents analysis settings.
/// </summary>
public sealed class AnalysisSettings
{
    public Guid Id { get; set; }

    public bool GeneratePreview { get; set; }

    public bool GenerateStatistics { get; set; }

    public bool SaveIntermediateFiles { get; set; }

    public string DefaultOutputFormat { get; set; } = "GeoTIFF";

    public int MaxParallelJobs { get; set; }

    public DateTime UpdatedAtUtc { get; set; }
}
