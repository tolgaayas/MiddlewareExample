namespace MiddlewareExample.Extantions
{
   static public class Extansion
    {
        public static IApplicationBuilder UseHelloMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middlewares.HelloMiddleware>();
        }
        public static IServiceCollection AddHelloService(this IServiceCollection services)
        {
            // Register any services needed by the middleware here
            return services;
        }
    }
}
