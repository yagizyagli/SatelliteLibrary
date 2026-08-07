using Microsoft.AspNetCore.Mvc;
using Satellite.Api.DTOs;
using Satellite.Api.Services;

namespace Satellite.Api.Controllers;

[ApiController]
[Route("api/configuration")]
public sealed class ConfigurationController : ControllerBase
{
    private readonly IConfigurationService _configurationService;

    public ConfigurationController(IConfigurationService configurationService)
    {
        _configurationService = configurationService;
    }

    /// <summary>
    /// Returns the current application configuration.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetConfiguration()
    {
        var configuration = await _configurationService.GetConfigurationAsync();
        return Ok(configuration);
    }

    /// <summary>
    /// Updates the application configuration.
    /// </summary>
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateConfiguration(
        [FromBody] ConfigurationDto request)
    {
        var configuration = await _configurationService.UpdateConfigurationAsync(request);
        return Ok(configuration);
    }

    /// <summary>
    /// Returns all supported satellite providers.
    /// </summary>
    [HttpGet("providers")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProviders()
    {
        var providers = await _configurationService.GetProvidersAsync();
        return Ok(providers);
    }

    /// <summary>
    /// Sets the default satellite provider.
    /// </summary>
    [HttpPut("providers/default")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> SetDefaultProvider(
        [FromBody] SetDefaultProviderDto request)
    {
        await _configurationService.SetDefaultProviderAsync(request.Provider);

        return Ok(new
        {
            message = "Default provider updated successfully."
        });
    }

    /// <summary>
    /// Returns all analysis settings.
    /// </summary>
    [HttpGet("analysis")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAnalysisSettings()
    {
        var settings = await _configurationService.GetAnalysisSettingsAsync();
        return Ok(settings);
    }

    /// <summary>
    /// Updates analysis settings.
    /// </summary>
    [HttpPut("analysis")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> UpdateAnalysisSettings(
        [FromBody] AnalysisSettingsDto request)
    {
        await _configurationService.UpdateAnalysisSettingsAsync(request);

        return Ok(new
        {
            message = "Analysis settings updated successfully."
        });
    }
}
