

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebshipperSharp;

namespace Vuffeli.Net.Worker.Library.Tests.Fixtures
{
    public class TestFixture
    {

        protected internal IConfiguration Configuration;
        protected internal ServiceProvider ServiceProvider;
        protected internal ServiceCollection ServiceCollection;
        protected internal IHostedService Service;

        public TestFixture()
        {
            ServiceCollection = new ServiceCollection();
            ServiceCollection.AddHostedService<TestService>();
            Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
            ServiceCollection.AddWebshipperSharp(x =>
            {
                var options = Configuration.GetSection("WebshipperSharpServiceOptions").Get<WebshipperSharpServiceOptions>();
                x.TenantName = options.TenantName;
                x.BearerToken = options.BearerToken;
            });
            ServiceProvider = ServiceCollection.BuildServiceProvider();
            Service = ServiceProvider.GetRequiredService<IHostedService>();
        }
    }
}
