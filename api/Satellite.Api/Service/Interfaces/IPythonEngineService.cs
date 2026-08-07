using Satellite.Api.DTOs;

namespace Satellite.Api.Services.Interfaces;

/// <summary>
/// Provides communication with the Python analysis engine.
/// </summary>
public interface IPythonEngineService
{
    Task<AnalysisResultDto> ExecuteAnalysisAsync(AnalysisRequest request);

    Task<bool> IsEngineAvailableAsync();

    Task RestartAsync();
}
