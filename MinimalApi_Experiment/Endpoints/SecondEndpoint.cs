using Asp.Versioning;
using Asp.Versioning.Builder;
using Microsoft.AspNetCore.Http.HttpResults;
using MinimalApi_Experiment.Endpoint;
using MinimalApi_Experiment.VersionSet;

namespace MinimalApi_Experiment.Endpoints;

public sealed class SecondEndpoint : IEndpoint
{
    public static ApiVersion EndpointVersion => ApiVersioning.V2;
    public static string Pattern => "second";
    public static HttpMethod Method => HttpMethod.Get;
    public static Delegate Handler => async Task<Ok<string>> () =>
    {
        await Task.Delay(1000);
       return TypedResults.Ok("second endpoint");
    };
}