﻿using Templator.Api.Extensions;

namespace Templator.Api.Middlewares
{
    public class HttpRequestLoggerMiddleware(
        RequestDelegate _next,
        ILogger<HttpRequestLoggerMiddleware> _logger
        )
    {
        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogApiInvoked(context, LogLevel.Information);

            await _next(context);
        }
    }
}
