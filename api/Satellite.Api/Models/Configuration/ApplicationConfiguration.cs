namespace Satellite.Api.Models.Configuration;

/// <summary>
/// Represents the application configuration.
/// </summary>
public sealed class ApplicationConfiguration
{
    public Guid Id { get; set; }

    public string DefaultProvider { get; set; } = string.Empty;

    public string DataDirectory { get; set; } = string.Empty;

    public string OutputDirectory { get; set; } = string.Empty;

    public string TemporaryDirectory { get; set; } = string.Empty;

    public bool EnableLogging { get; set; }

    public bool EnableCache { get; set; }

    public DateTime UpdatedAtUtc { get; set; }
}
