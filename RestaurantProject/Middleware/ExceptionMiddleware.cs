using Newtonsoft.Json;
using RestaurantProject.Exceptions;
using System.Net;

namespace RestaurantProject.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExceptionMiddleware(RequestDelegate next, ILoggerFactory logger)
        {
            _logger = logger.CreateLogger<ExceptionMiddleware>();
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (NotImplementedException ex)
            {
                _logger.LogWarning(ex, "Открытая ошибка");
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(new DetailsException { Code = "", Message = ex.Message }));

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Необработанная ошибка ");
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(new DetailsException { Code = "", Message = "Ошибка сервера" }));
            }
        }
    }
}
