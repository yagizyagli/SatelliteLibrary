namespace Satellite.Api.DTOs.Analysis;

/// <summary>
/// Represents a request to execute an analysis.
/// </summary>
public sealed class AnalysisRequest
{
    public Guid DatasetId { get; set; }

    public string AnalysisType { get; set; } = string.Empty;

    public Dictionary<string, object>? Parameters { get; set; }
}
