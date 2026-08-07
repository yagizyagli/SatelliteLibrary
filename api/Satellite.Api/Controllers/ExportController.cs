using Microsoft.AspNetCore.Mvc;
using Satellite.Api.Services;

namespace Satellite.Api.Controllers;

[ApiController]
[Route("api/export")]
public sealed class ExportController : ControllerBase
{
    private readonly IExportService _exportService;

    public ExportController(IExportService exportService)
    {
        _exportService = exportService;
    }

    /// <summary>
    /// Exports an analysis result as JSON.
    /// </summary>
    [HttpGet("{id:guid}/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ExportJson(Guid id)
    {
        var file = await _exportService.ExportJsonAsync(id);

        if (file is null)
            return NotFound();

        return File(file.Content, file.ContentType, file.FileName);
    }

    /// <summary>
    /// Exports an analysis result as CSV.
    /// </summary>
    [HttpGet("{id:guid}/csv")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ExportCsv(Guid id)
    {
        var file = await _exportService.ExportCsvAsync(id);

        if (file is null)
            return NotFound();

        return File(file.Content, file.ContentType, file.FileName);
    }

    /// <summary>
    /// Exports an analysis result as GeoJSON.
    /// </summary>
    [HttpGet("{id:guid}/geojson")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ExportGeoJson(Guid id)
    {
        var file = await _exportService.ExportGeoJsonAsync(id);

        if (file is null)
            return NotFound();

        return File(file.Content, file.ContentType, file.FileName);
    }

    /// <summary>
    /// Exports an analysis report.
    /// </summary>
    [HttpGet("{id:guid}/report")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ExportReport(Guid id)
    {
        var file = await _exportService.ExportReportAsync(id);

        if (file is null)
            return NotFound();

        return File(file.Content, file.ContentType, file.FileName);
    }
}
