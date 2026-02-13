namespace MultiThread.ExceptionHandlers;

public static class DependencyInjectionExtensions
{
    public static void AddExceptionHandlers(this IServiceCollection services)
    {
        services.AddProblemDetails();

        services.AddExceptionHandler<GlobalExceptionHandler>();
        services.AddExceptionHandler<TimeoutExceptionHandler>();
    }

    public static void UseCustomExceptionHandlers(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(configure =>
        {
            configure.Run(async context =>
            {
                var problemDetailsService = context.RequestServices
                    .GetRequiredService<IProblemDetailsService>();

                await problemDetailsService.TryWriteAsync(
                    new ProblemDetailsContext { HttpContext = context });
            });
        });
    }
}