namespace DemoVS
{
    public class MeuMiddleware
    {
        private readonly RequestDelegate _next;

        public MeuMiddleware(RequestDelegate next) 
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            //httpContext.Response.Headers.Add("X-Meu-Middleware", "Funcinou");
            await _next(httpContext);
        }
    }
}
