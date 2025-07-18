using Microsoft.AspNetCore.Builder;
using MiddlewareExample.Middlewares;
using System.Threading.RateLimiting;

namespace MiddlewareExample.Extansions
{
    static public class RequestResponseExtansion
    { 
        public static IApplicationBuilder UseRequestResponseMiddileware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestResponseMiddleware>(); 
        }

        public static IServiceCollection AddRequestResponseService(this IServiceCollection services)
        {
            // Register any services needed by the middleware here
            return services;
        }
    }
}
