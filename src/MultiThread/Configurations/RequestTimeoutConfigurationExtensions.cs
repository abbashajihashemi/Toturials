using Microsoft.AspNetCore.Http.Timeouts;

namespace MultiThread.Configurations;

public static class RequestTimeoutConfigurationExtensions
{
    public static void AddCustomRequestTimeouts(this IServiceCollection services, IConfiguration configuration)
    {
        var config = configuration.GetValue<int>("RequestTimeoutFromSeconds");

        services.AddRequestTimeouts(options =>
        {
            options.DefaultPolicy = new RequestTimeoutPolicy
            {
                Timeout = TimeSpan.FromSeconds(config),
                TimeoutStatusCode = StatusCodes.Status408RequestTimeout,

                WriteTimeoutResponse = async context =>
                {
                    context.Response.ContentType = "application/json; charset=utf-8";
                    context.Response.StatusCode = StatusCodes.Status408RequestTimeout;

                    var error = new
                    {
                        message = "Your request timeout has been exceeded",
                        status = 408,
                        timestamp = DateTime.UtcNow
                    };

                    await context.Response.WriteAsJsonAsync(error);
                }
            };
        });
    }
}