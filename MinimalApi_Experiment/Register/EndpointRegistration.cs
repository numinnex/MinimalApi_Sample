using MinimalApi_Experiment.Endpoint;
using MinimalApi_Experiment.Endpoints;

namespace MinimalApi_Experiment.Register;

public static class EndpointRegistration
{
    public static void RegisterEndpoints(this WebApplication app)
    {
        var api = app.NewVersionedApi().WithTags("tag");
        api.MapEndpoint<HelloWorldEndpoint>();
        api.MapEndpoint<SecondEndpoint>();
    } 
    }