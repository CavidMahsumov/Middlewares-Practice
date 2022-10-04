﻿namespace MiddleWare.Middlewares
{
    public class RequestEditingMiddleware
    {
        private  RequestDelegate _requestDelegate;

        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.ToString() == "/Cavid")
                await context.Response.WriteAsync("Salam Radnoyy");
            else
                await _requestDelegate.Invoke(context);
        }
    }
}
