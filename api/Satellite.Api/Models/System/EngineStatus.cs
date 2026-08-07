namespace Satellite.Api.Models.System;

/// <summary>
/// Represents the status of the Python engine.
/// </summary>
public sealed class EngineStatus
{
    public bool IsRunning { get; set; }

    public string Version { get; set; } = string.Empty;

    public string PythonVersion { get; set; } = string.Empty;

    public int ActiveJobs { get; set; }

    public DateTime LastStartedUtc { get; set; }
}
