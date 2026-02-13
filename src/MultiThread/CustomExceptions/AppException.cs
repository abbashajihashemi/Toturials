namespace MultiThread.CustomExceptions;

public class AppException : Exception
{
    public AppException()
    {
    }

    public AppException(string? message) : base(message)
    {
    }

    public AppException(
        string? message,
        Exception? innerException) : base(message, innerException)
    {
    }

    public AppException(
        int statusCode,
        string? message = null,
        Exception? innerException = null) : base(message, innerException)
    {
        StatusCode = statusCode;
    }

    public int StatusCode { get; }
}