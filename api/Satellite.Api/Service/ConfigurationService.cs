using Satellite.Api.DTOs.Configuration;
using Satellite.Api.Services.Interfaces;

namespace Satellite.Api.Services;

/// <summary>
/// Provides application configuration operations.
/// </summary>
public sealed class ConfigurationService : IConfigurationService
{
    private ConfigurationDto _configuration = new()
    {
        DefaultProvider = "Sentinel-2",
        DataDirectory = "data/raw",
        OutputDirectory = "data/results",
        TemporaryDirectory = "data/temp",
        EnableLogging = true,
        EnableCache = true
    };


    private AnalysisSettingsDto _settings = new()
    {
        GeneratePreview = true,
        GenerateStatistics = true,
        SaveIntermediateFiles = false,
        DefaultOutputFormat = "GeoTIFF",
        MaxParallelJobs = 2
    };


    public Task<ConfigurationDto> GetConfigurationAsync()
    {
        return Task.FromResult(_configuration);
    }


    public Task<ConfigurationDto> UpdateConfigurationAsync(
        ConfigurationDto configuration)
    {
        _configuration = configuration;

        return Task.FromResult(_configuration);
    }


    public Task<IEnumerable<SatelliteProviderDto>> GetProvidersAsync()
    {
        var providers = new List<SatelliteProviderDto>
        {
            new()
            {
                Name = "Sentinel-2",
                DisplayName = "Sentinel-2",
                IsAvailable = true
            }
        };

        return Task.FromResult<IEnumerable<SatelliteProviderDto>>(providers);
    }


    public Task SetDefaultProviderAsync(string provider)
    {
        _configuration.DefaultProvider = provider;

        return Task.CompletedTask;
    }


    public Task<AnalysisSettingsDto> GetAnalysisSettingsAsync()
    {
        return Task.FromResult(_settings);
    }


    public Task UpdateAnalysisSettingsAsync(
        AnalysisSettingsDto settings)
    {
        _settings = settings;

        return Task.CompletedTask;
    }
}
