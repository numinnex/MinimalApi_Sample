using Asp.Versioning;
using Asp.Versioning.Builder;
using MinimalApi_Experiment.VersionSet;

namespace MinimalApi_Experiment.Endpoint;

public static class EndpointBuilder
{
    public static RouteHandlerBuilder MapEndpoint<T>(this RouteGroupBuilder app)
    where T : IEndpoint
    {
        return app.MapMethods(
            T.Pattern,
            new[] { T.Method.ToString() },
            T.Handler
        ).HasApiVersion(T.EndpointVersion);
    } 
}