namespace Satellite.Api.DTOs.System;

/// <summary>
/// Represents general system information.
/// </summary>
public sealed class SystemInfoDto
{
    public string ApplicationName { get; set; } = string.Empty;

    public string Version { get; set; } = string.Empty;

    public string OperatingSystem { get; set; } = string.Empty;

    public string DotNetVersion { get; set; } = string.Empty;

    public DateTime ServerTimeUtc { get; set; }

    public TimeSpan Uptime { get; set; }
}
