using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Satellite.Api.Controllers;

[ApiController]
[Route("api/health")]
public sealed class HealthController : ControllerBase
{
    /// <summary>
    /// Returns the current health status of the API.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetHealth()
    {
        return Ok(new
        {
            status = "Healthy",
            service = "Satellite Library API",
            version = Assembly.GetExecutingAssembly().GetName().Version?.ToString(),
            serverTimeUtc = DateTime.UtcNow
        });
    }

    /// <summary>
    /// Returns the current API version.
    /// </summary>
    [HttpGet("version")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetVersion()
    {
        return Ok(new
        {
            version = Assembly.GetExecutingAssembly().GetName().Version?.ToString()
        });
    }

    /// <summary>
    /// Returns a simple availability status.
    /// </summary>
    [HttpGet("status")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetStatus()
    {
        return Ok(new
        {
            status = "Online"
        });
    }
}
