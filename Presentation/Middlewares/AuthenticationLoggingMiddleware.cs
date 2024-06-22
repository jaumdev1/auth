namespace Presentation.Middlewares
{
    public class AuthenticationLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AuthenticationLoggingMiddleware> _logger;

        public AuthenticationLoggingMiddleware(RequestDelegate next, ILogger<AuthenticationLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var authorizationHeader = context.Request.Headers["Authorization"].FirstOrDefault();
            _logger.LogInformation($"Authorization Header: {authorizationHeader}");

            if (string.IsNullOrEmpty(authorizationHeader))
            {
                _logger.LogWarning("No Authorization Header found");
            }
            else
            {
                _logger.LogInformation("Authorization Header found");
            }

            await _next(context);
        }
    }


}
