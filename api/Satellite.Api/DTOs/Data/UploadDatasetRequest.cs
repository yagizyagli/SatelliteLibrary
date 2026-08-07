using Microsoft.AspNetCore.Http;

namespace Satellite.Api.DTOs.Data;

/// <summary>
/// Represents a dataset upload request.
/// </summary>
public sealed class UploadDatasetRequest
{
    public IFormFile File { get; set; } = default!;

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Provider { get; set; } = string.Empty;
}
