using Microsoft.AspNetCore.Mvc;
using Satellite.Api.Services;

namespace Satellite.Api.Controllers;

[ApiController]
[Route("api/system")]
public sealed class SystemController : ControllerBase
{
    private readonly ISystemService _systemService;

    public SystemController(ISystemService systemService)
    {
        _systemService = systemService;
    }

    /// <summary>
    /// Returns general system information.
    /// </summary>
    [HttpGet("info")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetSystemInfo()
    {
        var info = await _systemService.GetSystemInfoAsync();
        return Ok(info);
    }

    /// <summary>
    /// Returns the current status of the Python analysis engine.
    /// </summary>
    [HttpGet("engine")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetEngineStatus()
    {
        var status = await _systemService.GetEngineStatusAsync();
        return Ok(status);
    }

    /// <summary>
    /// Returns storage usage information.
    /// </summary>
    [HttpGet("storage")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetStorageInfo()
    {
        var storage = await _systemService.GetStorageInfoAsync();
        return Ok(storage);
    }

    /// <summary>
    /// Clears temporary cache files.
    /// </summary>
    [HttpPost("cache/clear")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> ClearCache()
    {
        await _systemService.ClearCacheAsync();

        return Ok(new
        {
            message = "Cache cleared successfully."
        });
    }

    /// <summary>
    /// Restarts the Python analysis engine.
    /// </summary>
    [HttpPost("engine/restart")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> RestartEngine()
    {
        await _systemService.RestartEngineAsync();

        return Ok(new
        {
            message = "Python analysis engine restarted successfully."
        });
    }
}
