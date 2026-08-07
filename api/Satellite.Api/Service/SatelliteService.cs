using Satellite.Api.DTOs.Satellite;
using Satellite.Api.Services.Interfaces;

namespace Satellite.Api.Services;

/// <summary>
/// Provides satellite data operations.
/// </summary>
public sealed class SatelliteService : ISatelliteService
{
    public Task<IEnumerable<SatelliteProviderDto>> GetProvidersAsync()
    {
        var providers = new List<SatelliteProviderDto>
        {
            new()
            {
                Name = "Sentinel-2",
                DisplayName = "Sentinel-2",
                Description = "European satellite imagery provider.",
                IsAvailable = true
            },
            new()
            {
                Name = "Landsat-8",
                DisplayName = "Landsat 8",
                Description = "NASA Earth observation satellite.",
                IsAvailable = true
            }
        };

        return Task.FromResult<IEnumerable<SatelliteProviderDto>>(providers);
    }


    public Task<IEnumerable<SatelliteImageDto>> GetImagesAsync()
    {
        var images = new List<SatelliteImageDto>();

        return Task.FromResult<IEnumerable<SatelliteImageDto>>(images);
    }


    public Task<SatelliteImageDto?> GetImageAsync(Guid id)
    {
        return Task.FromResult<SatelliteImageDto?>(null);
    }


    public Task<Guid> DownloadAsync(DownloadSatelliteRequest request)
    {
        var operationId = Guid.NewGuid();

        return Task.FromResult(operationId);
    }


    public Task<bool> DeleteImageAsync(Guid id)
    {
        return Task.FromResult(true);
    }
}
