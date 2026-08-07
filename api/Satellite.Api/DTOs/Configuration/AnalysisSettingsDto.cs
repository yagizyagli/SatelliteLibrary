namespace Satellite.Api.DTOs.Configuration;

/// <summary>
/// Represents analysis configuration settings.
/// </summary>
public sealed class AnalysisSettingsDto
{
    public bool GeneratePreview { get; set; }

    public bool GenerateStatistics { get; set; }

    public bool SaveIntermediateFiles { get; set; }

    public string DefaultOutputFormat { get; set; } = "GeoTIFF";

    public int MaxParallelJobs { get; set; } = 2;
}
