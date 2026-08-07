namespace Satellite.Api.DTOs.Configuration;

/// <summary>
/// Represents a request to change the default satellite provider.
/// </summary>
public sealed class SetDefaultProviderDto
{
    public string Provider { get; set; } = string.Empty;
}
