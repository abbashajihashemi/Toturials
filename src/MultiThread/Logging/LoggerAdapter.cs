namespace MultiThread.Logging;

public class LoggerAdapter<TType>(ILogger<TType> logger) : ILoggerAdapter<TType>
{
    public void LogInformation(string? message, params object?[] args)
    {
        logger.LogInformation(message, args);
    }

    public void LogWarning(string? message, params object?[] args)
    {
        logger.LogWarning(message, args);
    }

    public void LogWarning(Exception? exception, string? message, params object?[] args)
    {
        logger.LogWarning(exception, message, args);
    }

    public void LogError(Exception? exception, string? message, params object?[] args)
    {
        logger.LogError(exception, message, args);
    }

    public void LogCritical(Exception? exception, string? message, params object?[] args)
    {
        logger.LogCritical(exception, message, args);
    }
}