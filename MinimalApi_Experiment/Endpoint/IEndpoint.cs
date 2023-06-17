namespace MinimalApi_Experiment.Endpoint;

public interface IEndpoint
{
    public static abstract string Pattern { get; } 
    public static abstract HttpMethod Method { get; }
    public static abstract Delegate Handler { get; }
}