using MinimalApi_Experiment.Endpoint;
using MinimalApi_Experiment.Endpoints;

namespace MinimalApi_Experiment.Register;

public static class EndpointRegistration
{
    public static void RegisterEndpoints(this WebApplication app)
    {
        app.MapEndpoint<HelloWorldEndpoint>();
        app.MapEndpoint<SecondEndpoint>();
    } 
}