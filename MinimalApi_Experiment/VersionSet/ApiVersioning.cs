using Asp.Versioning;
using Asp.Versioning.Builder;

namespace MinimalApi_Experiment.VersionSet;

public static class ApiVersioning
{
    private const string ApiName = "MinimalApi_Experiment";
    public static ApiVersion V1 => new ApiVersion(1);
    public static ApiVersion V2 => new ApiVersion(2);
    public static ApiVersionSet Set => new ApiVersionSetBuilder(ApiName)
        .HasApiVersion(V1)
        .HasApiVersion(V2)
        .ReportApiVersions()
        .Build();
}