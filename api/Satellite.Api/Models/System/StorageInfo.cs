namespace Satellite.Api.Models.System;

/// <summary>
/// Represents storage information.
/// </summary>
public sealed class StorageInfo
{
    public long TotalSpace { get; set; }

    public long UsedSpace { get; set; }

    public long FreeSpace { get; set; }

    public int DatasetCount { get; set; }

    public int AnalysisCount { get; set; }
}
