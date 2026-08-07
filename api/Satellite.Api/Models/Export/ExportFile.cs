namespace Satellite.Api.Models.Export;

/// <summary>
/// Represents an exported file.
/// </summary>
public sealed class ExportFile
{
    public Guid Id { get; set; }

    public string FileName { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;

    public string ContentType { get; set; } = string.Empty;

    public long FileSize { get; set; }

    public DateTime ExportedAtUtc { get; set; }
}
