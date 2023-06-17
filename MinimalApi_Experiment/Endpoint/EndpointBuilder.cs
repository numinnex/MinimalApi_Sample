using Asp.Versioning;
using Asp.Versioning.Builder;

namespace MinimalApi_Experiment.Endpoint;

public static class EndpointBuilder
{
    public static RouteHandlerBuilder MapEndpoint<T>(this IVersionedEndpointRouteBuilder app)
    where T : IEndpoint
    {
        return app.MapMethods(
            T.Pattern,
            new[] { T.Method.ToString() },
            T.Handler
        ).HasApiVersion(T.EndpointVersion).MapToApiVersion(T.EndpointVersion);
    } 
}