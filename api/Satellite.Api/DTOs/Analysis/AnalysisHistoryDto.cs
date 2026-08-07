namespace Satellite.Api.DTOs.Analysis;

/// <summary>
/// Represents an analysis history item.
/// </summary>
public sealed class AnalysisHistoryDto
{
    public Guid AnalysisId { get; set; }

    public Guid DatasetId { get; set; }

    public string AnalysisType { get; set; } = string.Empty;

    public DateTime ExecutedAtUtc { get; set; }

    public string Status { get; set; } = string.Empty;
}
