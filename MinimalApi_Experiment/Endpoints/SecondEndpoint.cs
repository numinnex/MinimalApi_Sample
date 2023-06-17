using Microsoft.AspNetCore.Http.HttpResults;
using MinimalApi_Experiment.Endpoint;

namespace MinimalApi_Experiment.Endpoints;

public sealed class SecondEndpoint : IEndpoint
{
    public static string Pattern => "second";
    public static HttpMethod Method => HttpMethod.Get;
    public static Delegate Handler => Ok<string> () =>
    {
        return TypedResults.Ok("second endpoint");
    };
}