using Satellite.Api.DTOs;

namespace Satellite.Api.Services.Interfaces;

/// <summary>
/// Provides dataset management operations.
/// </summary>
public interface IDataService
{
    /// <summary>
    /// Returns all available datasets.
    /// </summary>
    Task<IReadOnlyCollection<DatasetDto>> GetDatasetsAsync();

    /// <summary>
    /// Returns dataset metadata.
    /// </summary>
    Task<DatasetMetadataDto?> GetMetadataAsync(Guid id);

    /// <summary>
    /// Uploads a new dataset.
    /// </summary>
    Task<Guid> UploadAsync(UploadDatasetRequest request);

    /// <summary>
    /// Deletes a dataset.
    /// </summary>
    Task<bool> DeleteAsync(Guid id);
}
