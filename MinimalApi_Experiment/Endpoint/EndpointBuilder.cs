namespace MinimalApi_Experiment.Endpoint;

public static class EndpointBuilder
{
    public static IEndpointRouteBuilder MapEndpoint<T>(this IEndpointRouteBuilder app)
    where T : IEndpoint
    {
        app.MapMethods(
            T.Pattern,
            new []{ T.Method.ToString()},
            T.Handler
            );
        return app;
    } 
}