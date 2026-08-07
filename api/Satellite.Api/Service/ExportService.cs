using Satellite.Api.DTOs.Export;
using Satellite.Api.Services.Interfaces;

namespace Satellite.Api.Services;

/// <summary>
/// Provides export operations.
/// </summary>
public sealed class ExportService : IExportService
{
    public Task<ExportFileDto?> ExportJsonAsync(Guid analysisId)
    {
        return Task.FromResult<ExportFileDto?>(CreateExport(
            analysisId,
            "json"));
    }


    public Task<ExportFileDto?> ExportCsvAsync(Guid analysisId)
    {
        return Task.FromResult<ExportFileDto?>(CreateExport(
            analysisId,
            "csv"));
    }


    public Task<ExportFileDto?> ExportGeoJsonAsync(Guid analysisId)
    {
        return Task.FromResult<ExportFileDto?>(CreateExport(
            analysisId,
            "geojson"));
    }


    public Task<ExportFileDto?> ExportReportAsync(Guid analysisId)
    {
        return Task.FromResult<ExportFileDto?>(CreateExport(
            analysisId,
            "pdf"));
    }


    private static ExportFileDto CreateExport(
        Guid analysisId,
        string format)
    {
        return new ExportFileDto
        {
            FileName = $"analysis-{analysisId}.{format}",
            ContentType = $"application/{format}",
            Content = Array.Empty<byte>(),
            FileSize = 0,
            CreatedAtUtc = DateTime.UtcNow
        };
    }
}
