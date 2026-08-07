using Satellite.Api.DTOs;

namespace Satellite.Api.Services.Interfaces;

/// <summary>
/// Provides application configuration operations.
/// </summary>
public interface IConfigurationService
{
    Task<ConfigurationDto> GetConfigurationAsync();

    Task<ConfigurationDto> UpdateConfigurationAsync(ConfigurationDto configuration);

    Task<IEnumerable<SatelliteProviderDto>> GetProvidersAsync();

    Task SetDefaultProviderAsync(string provider);

    Task<AnalysisSettingsDto> GetAnalysisSettingsAsync();

    Task UpdateAnalysisSettingsAsync(AnalysisSettingsDto settings);
}
