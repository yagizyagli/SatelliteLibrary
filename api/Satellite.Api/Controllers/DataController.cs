using Microsoft.AspNetCore.Mvc;
using Satellite.Api.DTOs;
using Satellite.Api.Services;

namespace Satellite.Api.Controllers;

[ApiController]
[Route("api/data")]
public sealed class DataController : ControllerBase
{
    private readonly IDataService _dataService;

    public DataController(IDataService dataService)
    {
        _dataService = dataService;
    }

    /// <summary>
    /// Returns all available datasets.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetDatasets()
    {
        var datasets = await _dataService.GetDatasetsAsync();
        return Ok(datasets);
    }

    /// <summary>
    /// Returns dataset metadata.
    /// </summary>
    [HttpGet("{id:guid}/metadata")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetMetadata(Guid id)
    {
        var metadata = await _dataService.GetMetadataAsync(id);

        if (metadata is null)
            return NotFound();

        return Ok(metadata);
    }

    /// <summary>
    /// Uploads a new dataset.
    /// </summary>
    [HttpPost("upload")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> UploadDataset(
        [FromForm] UploadDatasetRequest request)
    {
        var datasetId = await _dataService.UploadAsync(request);

        return CreatedAtAction(
            nameof(GetMetadata),
            new { id = datasetId },
            new
            {
                datasetId,
                message = "Dataset uploaded successfully."
            });
    }

    /// <summary>
    /// Deletes a dataset.
    /// </summary>
    [HttpDelete("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteDataset(Guid id)
    {
        var deleted = await _dataService.DeleteAsync(id);

        if (!deleted)
            return NotFound();

        return NoContent();
    }
}
