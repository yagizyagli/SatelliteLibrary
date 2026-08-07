using Satellite.Api.DTOs;

namespace Satellite.Api.Services.Interfaces;

/// <summary>
/// Provides system management operations.
/// </summary>
public interface ISystemService
{
    Task<SystemInfoDto> GetSystemInfoAsync();

    Task<EngineStatusDto> GetEngineStatusAsync();

    Task<StorageInfoDto> GetStorageInfoAsync();

    Task ClearCacheAsync();

    Task RestartEngineAsync();
}
