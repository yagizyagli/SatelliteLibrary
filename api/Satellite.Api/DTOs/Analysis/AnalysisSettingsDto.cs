namespace Satellite.Api.DTOs.Analysis;

/// <summary>
/// Represents configurable analysis settings.
/// </summary>
public sealed class AnalysisSettingsDto
{
    public bool SaveIntermediateFiles { get; set; }

    public bool GeneratePreview { get; set; }

    public bool GenerateStatistics { get; set; }

    public string OutputFormat { get; set; } = "json";
}
