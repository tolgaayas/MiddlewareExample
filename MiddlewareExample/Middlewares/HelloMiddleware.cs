using Microsoft.AspNetCore.Http.Features;

namespace MiddlewareExample.Middlewares
{
    public class HelloMiddleware 
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task  Invoke(HttpContext context)
        {
            //// Do something before the next middleware
            //await context.Response.WriteAsync("Hello from HelloMiddleware!\n");
            //// Call the next middleware in the pipeline
            //await _next(context);
            //// Do something after the next middleware
            //await context.Response.WriteAsync("Goodbye from HelloMiddleware!\n");
            Console.WriteLine("Hello from HelloMiddleware!");
            await _next.Invoke(context);
            Console.WriteLine("Goodbye from HelloMiddleware!");

        }

    }
}
