namespace APIBestPractices.Utilities
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Net;
    using System.Text.Json;
    using System.Threading.Tasks;

    namespace LibraryManagementAPI.Utilities
    {
        public class ErrorHandlerMiddleware
        {
            private readonly RequestDelegate _next;

            public ErrorHandlerMiddleware(RequestDelegate next)
            {
                _next = next;
            }

            public async Task Invoke(HttpContext context)
            {
                try
                {
                    await _next(context);
                }
                catch (Exception ex)
                {
                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                    var errorResponse = JsonSerializer.Serialize(new
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = "An error occurred while processing your request.",
                        Detailed = ex.Message
                    });

                    await context.Response.WriteAsync(errorResponse);
                }
            }
        }
    }
}
