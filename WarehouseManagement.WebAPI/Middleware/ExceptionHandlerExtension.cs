namespace WarehouseManagement.WebAPI.Middleware;

public static class ExceptionHandlerExtension {
    public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder app) {
        return app.UseMiddleware<ExceptionHandlerMiddleware>();
    }
}
