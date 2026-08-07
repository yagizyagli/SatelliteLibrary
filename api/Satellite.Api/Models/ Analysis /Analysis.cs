namespace Satellite.Api.Models.Analysis;

/// <summary>
/// Represents an analysis job.
/// </summary>
public sealed class Analysis
{
    public Guid Id { get; set; }

    public Guid DatasetId { get; set; }

    public string AnalysisType { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public DateTime StartedAtUtc { get; set; }

    public DateTime? CompletedAtUtc { get; set; }

    public string Parameters { get; set; } = string.Empty;
}
