using Microsoft.AspNetCore.Mvc;
using Satellite.Api.DTOs;
using Satellite.Api.Services;

namespace Satellite.Api.Controllers;

[ApiController]
[Route("api/analysis")]
public sealed class AnalysisController : ControllerBase
{
    private readonly IAnalysisService _analysisService;

    public AnalysisController(IAnalysisService analysisService)
    {
        _analysisService = analysisService;
    }

    /// <summary>
    /// Starts a complete analysis pipeline.
    /// </summary>
    [HttpPost("run")]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<IActionResult> RunAnalysis(
        [FromBody] AnalysisRequest request)
    {
        var operationId = await _analysisService.RunAnalysisAsync(request);

        return Accepted(new
        {
            operationId,
            message = "Analysis has been started."
        });
    }

    /// <summary>
    /// Executes an NDVI analysis.
    /// </summary>
    [HttpPost("ndvi")]
    public async Task<IActionResult> RunNdvi(
        [FromBody] AnalysisRequest request)
    {
        var result = await _analysisService.RunNdviAsync(request);
        return Ok(result);
    }

    /// <summary>
    /// Executes vegetation analysis.
    /// </summary>
    [HttpPost("vegetation")]
    public async Task<IActionResult> RunVegetation(
        [FromBody] AnalysisRequest request)
    {
        var result = await _analysisService.RunVegetationAsync(request);
        return Ok(result);
    }

    /// <summary>
    /// Executes water analysis.
    /// </summary>
    [HttpPost("water")]
    public async Task<IActionResult> RunWater(
        [FromBody] AnalysisRequest request)
    {
        var result = await _analysisService.RunWaterAsync(request);
        return Ok(result);
    }

    /// <summary>
    /// Executes terrain analysis.
    /// </summary>
    [HttpPost("terrain")]
    public async Task<IActionResult> RunTerrain(
        [FromBody] AnalysisRequest request)
    {
        var result = await _analysisService.RunTerrainAsync(request);
        return Ok(result);
    }

    /// <summary>
    /// Executes change detection.
    /// </summary>
    [HttpPost("change-detection")]
    public async Task<IActionResult> RunChangeDetection(
        [FromBody] AnalysisRequest request)
    {
        var result = await _analysisService.RunChangeDetectionAsync(request);
        return Ok(result);
    }

    /// <summary>
    /// Generates image statistics.
    /// </summary>
    [HttpPost("statistics")]
    public async Task<IActionResult> RunStatistics(
        [FromBody] AnalysisRequest request)
    {
        var result = await _analysisService.RunStatisticsAsync(request);
        return Ok(result);
    }

    /// <summary>
    /// Returns an analysis result.
    /// </summary>
    [HttpGet("results/{id:guid}")]
    public async Task<IActionResult> GetResult(Guid id)
    {
        var result = await _analysisService.GetResultAsync(id);

        if (result is null)
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Returns all analysis history.
    /// </summary>
    [HttpGet("history")]
    public async Task<IActionResult> GetHistory()
    {
        var history = await _analysisService.GetHistoryAsync();
        return Ok(history);
    }
}
