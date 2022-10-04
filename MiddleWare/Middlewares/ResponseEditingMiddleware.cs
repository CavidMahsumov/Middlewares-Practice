namespace MiddleWare.Middlewares
{
    public class ResponseEditingMiddleware
    {
        private RequestDelegate _requestDelegate;

        public ResponseEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            await _requestDelegate(context);
            if (context.Response.StatusCode == StatusCodes.Status404NotFound)
                 await context.Response.WriteAsync("Page Not Found");
        }
    }
}
