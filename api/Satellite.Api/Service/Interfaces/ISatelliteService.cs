using Satellite.Api.DTOs;

namespace Satellite.Api.Services.Interfaces;

/// <summary>
/// Provides operations for managing satellite providers and imagery.
/// </summary>
public interface ISatelliteService
{
    /// <summary>
    /// Returns all supported satellite providers.
    /// </summary>
    Task<IEnumerable<SatelliteProviderDto>> GetProvidersAsync();

    /// <summary>
    /// Returns all downloaded satellite images.
    /// </summary>
    Task<IEnumerable<SatelliteImageDto>> GetImagesAsync();

    /// <summary>
    /// Returns a satellite image by its identifier.
    /// </summary>
    Task<SatelliteImageDto?> GetImageAsync(Guid id);

    /// <summary>
    /// Downloads a new satellite image.
    /// </summary>
    Task<Guid> DownloadAsync(DownloadSatelliteRequest request);

    /// <summary>
    /// Deletes a satellite image.
    /// </summary>
    Task<bool> DeleteImageAsync(Guid id);
}
