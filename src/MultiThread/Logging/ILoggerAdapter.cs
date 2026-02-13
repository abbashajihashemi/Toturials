namespace MultiThread.Logging;

public interface ILoggerAdapter<TType>
{
    void LogInformation(string? message, params object?[] args);
    void LogWarning(string? message, params object?[] args);
    void LogWarning(Exception? exception, string? message, params object?[] args);
    void LogError(Exception? exception, string? message, params object?[] args);
    void LogCritical(Exception? exception, string? message, params object?[] args);
}