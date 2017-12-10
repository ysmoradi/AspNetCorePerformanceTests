using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCorePerformanceTests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            RouteBuilder routeBuilder = new RouteBuilder(app);

            routeBuilder.MapGet("api/values/{id}", context =>
            {
                return context.Response.WriteAsync((string)context.GetRouteValue("id"));
            });

            IRouter routes = routeBuilder.Build();

            app.UseRouter(routes);
        }
    }
}
