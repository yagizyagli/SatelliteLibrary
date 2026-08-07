namespace Satellite.Api.DTOs.Data;

/// <summary>
/// Represents a dataset.
/// </summary>
public sealed class DatasetDto
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Provider { get; set; } = string.Empty;

    public long FileSize { get; set; }

    public string FileFormat { get; set; } = string.Empty;

    public DateTime CreatedAtUtc { get; set; }

    public DateTime UpdatedAtUtc { get; set; }
}
