using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MultiThread.ExceptionHandlers;

public class TimeoutExceptionHandler(ILogger<TimeoutExceptionHandler> logger) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        if (exception is not OperationCanceledException oce ||
            !httpContext.RequestAborted.IsCancellationRequested)
        {
            return false;
        }

        logger.LogWarning(oce, "Request cancelled after timeout → {Path}", httpContext.Request.Path);

        httpContext.Response.StatusCode = StatusCodes.Status408RequestTimeout;
        httpContext.Response.ContentType = "application/problem+json";

        var problem = new ProblemDetails
        {
            Type = "https://tools.ietf.org/html/rfc7231#section-6.5.7",
            Title = "Request Timeout",
            Status = StatusCodes.Status408RequestTimeout,
            Detail = "The request took longer than allowed and was canceled",
            Instance = httpContext.Request.Path
        };

        await httpContext.Response.WriteAsJsonAsync(problem, cancellationToken);

        return true;
    }
}