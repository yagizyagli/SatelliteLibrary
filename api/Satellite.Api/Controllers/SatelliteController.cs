using Microsoft.AspNetCore.Mvc;
using Satellite.Api.DTOs;
using Satellite.Api.Services;

namespace Satellite.Api.Controllers;

[ApiController]
[Route("api/satellite")]
public sealed class SatelliteController : ControllerBase
{
    private readonly ISatelliteService _satelliteService;

    public SatelliteController(ISatelliteService satelliteService)
    {
        _satelliteService = satelliteService;
    }

    /// <summary>
    /// Returns all supported satellite providers.
    /// </summary>
    [HttpGet("providers")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProviders()
    {
        var providers = await _satelliteService.GetProvidersAsync();
        return Ok(providers);
    }

    /// <summary>
    /// Returns downloaded satellite images.
    /// </summary>
    [HttpGet("images")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetImages()
    {
        var images = await _satelliteService.GetImagesAsync();
        return Ok(images);
    }

    /// <summary>
    /// Returns a satellite image by its identifier.
    /// </summary>
    [HttpGet("images/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetImage(Guid id)
    {
        var image = await _satelliteService.GetImageAsync(id);

        if (image is null)
            return NotFound();

        return Ok(image);
    }

    /// <summary>
    /// Downloads a new satellite image.
    /// </summary>
    [HttpPost("download")]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DownloadImage(
        [FromBody] DownloadSatelliteRequest request)
    {
        var operationId = await _satelliteService.DownloadAsync(request);

        return Accepted(new
        {
            operationId,
            message = "Satellite download has been started."
        });
    }

    /// <summary>
    /// Deletes a downloaded satellite image.
    /// </summary>
    [HttpDelete("images/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteImage(Guid id)
    {
        var deleted = await _satelliteService.DeleteImageAsync(id);

        if (!deleted)
            return NotFound();

        return NoContent();
    }
}
