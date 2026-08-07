namespace Satellite.Api.DTOs.Satellite;

/// <summary>
/// Represents the result of a download operation.
/// </summary>
public sealed class SatelliteDownloadResultDto
{
    public Guid OperationId { get; set; }

    public bool Success { get; set; }

    public string Message { get; set; } = string.Empty;

    public DateTime StartedAtUtc { get; set; }
}
