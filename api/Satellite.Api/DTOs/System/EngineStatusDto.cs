namespace Satellite.Api.DTOs.System;

/// <summary>
/// Represents the status of the Python engine.
/// </summary>
public sealed class EngineStatusDto
{
    public bool IsRunning { get; set; }

    public string Version { get; set; } = string.Empty;

    public string PythonVersion { get; set; } = string.Empty;

    public DateTime LastStartedUtc { get; set; }

    public int ActiveJobs { get; set; }
}
