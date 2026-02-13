namespace MultiThread.Logging;

public static class DependencyInjectionExtensions
{
    public static void AddLoggerAdapter(this IServiceCollection services)
    {
        services.AddTransient(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
    }
}