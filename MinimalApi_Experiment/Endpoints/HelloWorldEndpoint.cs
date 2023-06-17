using Asp.Versioning;
using Asp.Versioning.Builder;
using Microsoft.AspNetCore.Http.HttpResults;
using MinimalApi_Experiment.Endpoint;
using MinimalApi_Experiment.VersionSet;

namespace MinimalApi_Experiment.Endpoints;

public sealed class HelloWorldEndpoint : IEndpoint
{
    public static ApiVersion EndpointVersion => ApiVersioning.V1;
    public static string Pattern  => "hello";
    public static HttpMethod Method => HttpMethod.Get;

    public static Delegate Handler => Ok<string> () =>
    {
        return TypedResults.Ok("hello world");
    };
}