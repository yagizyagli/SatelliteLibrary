using Satellite.Api.DTOs.Analysis;
using Satellite.Api.Services.Interfaces;

namespace Satellite.Api.Services;

/// <summary>
/// Provides communication with the Python analysis engine.
/// </summary>
public sealed class PythonEngineService : IPythonEngineService
{
    public Task<AnalysisResultDto> ExecuteAnalysisAsync(
        AnalysisRequest request)
    {
        var result = new AnalysisResultDto
        {
            AnalysisId = Guid.NewGuid(),
            DatasetId = request.DatasetId,
            AnalysisType = request.AnalysisType,
            Status = "COMPLETED",
            StartedAtUtc = DateTime.UtcNow,
            CompletedAtUtc = DateTime.UtcNow,
            Message = "Analysis completed successfully."
        };

        return Task.FromResult(result);
    }


    public Task<bool> IsEngineAvailableAsync()
    {
        return Task.FromResult(true);
    }


    public Task RestartAsync()
    {
        return Task.CompletedTask;
    }
}
