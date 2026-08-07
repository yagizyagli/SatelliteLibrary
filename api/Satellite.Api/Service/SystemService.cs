using Satellite.Api.DTOs.System;
using Satellite.Api.Services.Interfaces;

namespace Satellite.Api.Services;

/// <summary>
/// Provides system information operations.
/// </summary>
public sealed class SystemService : ISystemService
{
    private readonly DateTime _startTime = DateTime.UtcNow;


    public Task<SystemInfoDto> GetSystemInfoAsync()
    {
        var info = new SystemInfoDto
        {
            ApplicationName = "Satellite Library",
            Version = "1.0.0",
            OperatingSystem = Environment.OSVersion.ToString(),
            DotNetVersion = Environment.Version.ToString(),
            ServerTimeUtc = DateTime.UtcNow,
            Uptime = DateTime.UtcNow - _startTime
        };

        return Task.FromResult(info);
    }


    public Task<EngineStatusDto> GetEngineStatusAsync()
    {
        var status = new EngineStatusDto
        {
            IsRunning = true,
            Version = "1.0.0",
            PythonVersion = "3.x",
            ActiveJobs = 0,
            LastStartedUtc = _startTime
        };

        return Task.FromResult(status);
    }


    public Task<StorageInfoDto> GetStorageInfoAsync()
    {
        var storage = new StorageInfoDto
        {
            TotalSpace = 0,
            UsedSpace = 0,
            FreeSpace = 0,
            DatasetCount = 0,
            AnalysisCount = 0
        };

        return Task.FromResult(storage);
    }


    public Task ClearCacheAsync()
    {
        return Task.CompletedTask;
    }


    public Task RestartEngineAsync()
    {
        return Task.CompletedTask;
    }
}
