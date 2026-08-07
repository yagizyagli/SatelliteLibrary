using Satellite.Api.DTOs.Data;
using Satellite.Api.Services.Interfaces;

namespace Satellite.Api.Services;

/// <summary>
/// Provides dataset management operations.
/// </summary>
public sealed class DataService : IDataService
{
    private readonly List<DatasetDto> _datasets = new();


    public Task<IReadOnlyCollection<DatasetDto>> GetDatasetsAsync()
    {
        return Task.FromResult<IReadOnlyCollection<DatasetDto>>(_datasets);
    }


    public Task<DatasetMetadataDto?> GetMetadataAsync(Guid id)
    {
        return Task.FromResult<DatasetMetadataDto?>(null);
    }


    public Task<Guid> UploadAsync(UploadDatasetRequest request)
    {
        var datasetId = Guid.NewGuid();

        _datasets.Add(new DatasetDto
        {
            Id = datasetId,
            Name = request.Name,
            Description = request.Description,
            Provider = request.Provider,
            CreatedAtUtc = DateTime.UtcNow,
            UpdatedAtUtc = DateTime.UtcNow
        });

        return Task.FromResult(datasetId);
    }


    public Task<bool> DeleteAsync(Guid id)
    {
        var dataset = _datasets.FirstOrDefault(x => x.Id == id);

        if (dataset == null)
        {
            return Task.FromResult(false);
        }

        _datasets.Remove(dataset);

        return Task.FromResult(true);
    }
}
