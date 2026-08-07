using Satellite.Api.DTOs;

namespace Satellite.Api.Services.Interfaces;

/// <summary>
/// Provides satellite image analysis operations.
/// </summary>
public interface IAnalysisService
{
    /// <summary>
    /// Starts a complete analysis pipeline.
    /// </summary>
    Task<Guid> RunAnalysisAsync(AnalysisRequest request);

    /// <summary>
    /// Executes NDVI analysis.
    /// </summary>
    Task<AnalysisResultDto> RunNdviAsync(AnalysisRequest request);

    /// <summary>
    /// Executes vegetation analysis.
    /// </summary>
    Task<AnalysisResultDto> RunVegetationAsync(AnalysisRequest request);

    /// <summary>
    /// Executes water analysis.
    /// </summary>
    Task<AnalysisResultDto> RunWaterAsync(AnalysisRequest request);

    /// <summary>
    /// Executes terrain analysis.
    /// </summary>
    Task<AnalysisResultDto> RunTerrainAsync(AnalysisRequest request);

    /// <summary>
    /// Executes change detection analysis.
    /// </summary>
    Task<AnalysisResultDto> RunChangeDetectionAsync(AnalysisRequest request);

    /// <summary>
    /// Generates image statistics.
    /// </summary>
    Task<AnalysisResultDto> RunStatisticsAsync(AnalysisRequest request);

    /// <summary>
    /// Generates an analysis report.
    /// </summary>
    Task<AnalysisResultDto> GenerateReportAsync(Guid analysisId);

    /// <summary>
    /// Returns an analysis result.
    /// </summary>
    Task<AnalysisResultDto?> GetResultAsync(Guid analysisId);

    /// <summary>
    /// Returns the analysis history.
    /// </summary>
    Task<IEnumerable<AnalysisResultDto>> GetHistoryAsync();

    /// <summary>
    /// Deletes an analysis result.
    /// </summary>
    Task<bool> DeleteResultAsync(Guid analysisId);
}
