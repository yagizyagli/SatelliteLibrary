namespace Satellite.Api.Models.Analysis;

/// <summary>
/// Represents an analysis result.
/// </summary>
public sealed class AnalysisResult
{
    public Guid Id { get; set; }

    public Guid AnalysisId { get; set; }

    public string OutputFile { get; set; } = string.Empty;

    public string OutputFormat { get; set; } = string.Empty;

    public string Summary { get; set; } = string.Empty;

    public bool Success { get; set; }

    public DateTime CreatedAtUtc { get; set; }
}
