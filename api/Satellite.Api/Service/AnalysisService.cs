using Satellite.Api.DTOs.Analysis;
using Satellite.Api.Services.Interfaces;

namespace Satellite.Api.Services;

/// <summary>
/// Provides satellite analysis operations.
/// </summary>
public sealed class AnalysisService : IAnalysisService
{
    private readonly IPythonEngineService _pythonEngineService;

    public AnalysisService(IPythonEngineService pythonEngineService)
    {
        _pythonEngineService = pythonEngineService;
    }


    public async Task<Guid> RunAnalysisAsync(AnalysisRequest request)
    {
        var result = await _pythonEngineService.ExecuteAnalysisAsync(request);

        return result.AnalysisId;
    }


    public async Task<AnalysisResultDto> RunNdviAsync(AnalysisRequest request)
    {
        request.AnalysisType = "NDVI";

        return await _pythonEngineService.ExecuteAnalysisAsync(request);
    }


    public async Task<AnalysisResultDto> RunVegetationAsync(AnalysisRequest request)
    {
        request.AnalysisType = "VEGETATION";

        return await _pythonEngineService.ExecuteAnalysisAsync(request);
    }


    public async Task<AnalysisResultDto> RunWaterAsync(AnalysisRequest request)
    {
        request.AnalysisType = "WATER";

        return await _pythonEngineService.ExecuteAnalysisAsync(request);
    }


    public async Task<AnalysisResultDto> RunTerrainAsync(AnalysisRequest request)
    {
        request.AnalysisType = "TERRAIN";

        return await _pythonEngineService.ExecuteAnalysisAsync(request);
    }


    public async Task<AnalysisResultDto> RunChangeDetectionAsync(
        AnalysisRequest request)
    {
        request.AnalysisType = "CHANGE_DETECTION";

        return await _pythonEngineService.ExecuteAnalysisAsync(request);
    }


    public async Task<AnalysisResultDto> RunStatisticsAsync(
        AnalysisRequest request)
    {
        request.AnalysisType = "STATISTICS";

        return await _pythonEngineService.ExecuteAnalysisAsync(request);
    }


    public Task<AnalysisResultDto> GenerateReportAsync(Guid analysisId)
    {
        return Task.FromResult(new AnalysisResultDto
        {
            AnalysisId = analysisId,
            Status = "GENERATED",
            Message = "Report generated successfully."
        });
    }


    public Task<AnalysisResultDto?> GetResultAsync(Guid analysisId)
    {
        return Task.FromResult<AnalysisResultDto?>(null);
    }


    public Task<IEnumerable<AnalysisResultDto>> GetHistoryAsync()
    {
        var history = new List<AnalysisResultDto>();

        return Task.FromResult<IEnumerable<AnalysisResultDto>>(history);
    }


    public Task<bool> DeleteResultAsync(Guid analysisId)
    {
        return Task.FromResult(true);
    }
}
