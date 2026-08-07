namespace Satellite.Api.Models.Data;

/// <summary>
/// Represents a dataset.
/// </summary>
public sealed class Dataset
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Provider { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;

    public string FileFormat { get; set; } = string.Empty;

    public long FileSize { get; set; }

    public DateTime CreatedAtUtc { get; set; }
}
