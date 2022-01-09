using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

namespace WebshipperSharp
{
    public static class WebshipperSharpServiceCollection
    {
        public static IServiceCollection AddWebshipperSharp(this IServiceCollection services, Action<WebshipperSharpServiceOptions> options)
        {
            services.Configure(options);

            services.AddHttpClient("WebshipperSharpClient", (services, opts) =>
            {
                var options = services.GetRequiredService<WebshipperSharpServiceOptions>();

                opts.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                opts.BaseAddress = new Uri($"https://{options.TenantName}.api.webshipper.io/v2/");

                opts.DefaultRequestHeaders.Authorization =  new AuthenticationHeaderValue("Bearer", options.BearerToken);
            }).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler() { MaxConnectionsPerServer = 256 });

            services.AddTransient(x => options);
            services.AddLogging();

            services.AddTransient<WebshipperSharpService>();

            return services;
        }
    }
}

