namespace MiddlewareExample.Middlewares
{
    public class RequestResponseMiddleware
    {

        private readonly RequestDelegate _next; 
        public RequestResponseMiddleware(RequestDelegate next) { 
            _next = next;
        }
         
        public async Task Invoke(HttpContext context)
        {
            // Do something before the next middleware
            Console.WriteLine("Request received: " + context.Request.Method + " " + context.Request.Path);
            // Call the next middleware in the pipeline
            await _next.Invoke(context);
            // Do something after the next middleware
            Console.WriteLine("Response sent: " + context.Response.StatusCode+ "-" + context.Response.Body);
        }
    }
}
