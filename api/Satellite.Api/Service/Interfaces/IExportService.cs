using Satellite.Api.DTOs;

namespace Satellite.Api.Services.Interfaces;

/// <summary>
/// Provides export operations for analysis results.
/// </summary>
public interface IExportService
{
    Task<ExportFileDto?> ExportJsonAsync(Guid analysisId);

    Task<ExportFileDto?> ExportCsvAsync(Guid analysisId);

    Task<ExportFileDto?> ExportGeoJsonAsync(Guid analysisId);

    Task<ExportFileDto?> ExportReportAsync(Guid analysisId);
}
