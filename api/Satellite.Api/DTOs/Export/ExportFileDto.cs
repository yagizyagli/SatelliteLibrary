namespace Satellite.Api.DTOs.Export;

/// <summary>
/// Represents an exported file.
/// </summary>
public sealed class ExportFileDto
{
    public byte[] Content { get; set; } = Array.Empty<byte>();

    public string FileName { get; set; } = string.Empty;

    public string ContentType { get; set; } = string.Empty;

    public long FileSize { get; set; }

    public DateTime CreatedAtUtc { get; set; }
}
