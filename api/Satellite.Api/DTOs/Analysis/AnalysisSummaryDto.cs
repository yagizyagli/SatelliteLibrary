namespace Satellite.Api.DTOs.Analysis;

/// <summary>
/// Represents a summarized analysis result.
/// </summary>
public sealed class AnalysisSummaryDto
{
    public Guid AnalysisId { get; set; }

    public string AnalysisType { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public DateTime CompletedAtUtc { get; set; }
}
