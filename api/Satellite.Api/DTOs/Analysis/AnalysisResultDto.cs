namespace Satellite.Api.DTOs.Analysis;

/// <summary>
/// Represents the result of an analysis.
/// </summary>
public sealed class AnalysisResultDto
{
    public Guid AnalysisId { get; set; }

    public Guid DatasetId { get; set; }

    public string AnalysisType { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public DateTime StartedAtUtc { get; set; }

    public DateTime? CompletedAtUtc { get; set; }

    public string? OutputFile { get; set; }

    public string? Message { get; set; }
}
