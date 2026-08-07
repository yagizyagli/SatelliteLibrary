namespace Satellite.Api.Models.Analysis;

/// <summary>
/// Represents an analysis history entry.
/// </summary>
public sealed class AnalysisHistory
{
    public Guid Id { get; set; }

    public Guid AnalysisId { get; set; }

    public string Action { get; set; } = string.Empty;

    public DateTime TimestampUtc { get; set; }

    public string PerformedBy { get; set; } = string.Empty;
}
