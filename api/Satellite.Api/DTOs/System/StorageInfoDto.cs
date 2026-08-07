namespace Satellite.Api.DTOs.System;

/// <summary>
/// Represents storage usage information.
/// </summary>
public sealed class StorageInfoDto
{
    public long TotalSpace { get; set; }

    public long UsedSpace { get; set; }

    public long FreeSpace { get; set; }

    public int DatasetCount { get; set; }

    public int AnalysisCount { get; set; }
}
