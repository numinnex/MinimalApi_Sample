using MinimalApi_Experiment.Endpoint;
using MinimalApi_Experiment.Endpoints;
using MinimalApi_Experiment.VersionSet;

namespace MinimalApi_Experiment.Register;

public static class EndpointRegistration
{
    public static void RegisterEndpoints(this WebApplication app)
    {
        var api = app.MapGroup("/test");
        api.WithApiVersionSet(ApiVersioning.Set);
        api.WithTags("tag");
        
        api.MapEndpoint<HelloWorldEndpoint>();
        api.MapEndpoint<SecondEndpoint>();
    } 
    }