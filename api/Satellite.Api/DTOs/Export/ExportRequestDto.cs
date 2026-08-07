namespace Satellite.Api.DTOs.Export;

/// <summary>
/// Represents an export request.
/// </summary>
public sealed class ExportRequestDto
{
    public Guid AnalysisId { get; set; }

    public string Format { get; set; } = string.Empty;

    public bool IncludeMetadata { get; set; }

    public bool CompressOutput { get; set; }
}
