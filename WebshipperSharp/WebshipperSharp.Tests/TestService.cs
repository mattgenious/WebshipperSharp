using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

//using Org.BouncyCastle.Security;

namespace Vuffeli.Net.Worker.Library.Tests
{
    public class TestService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {               
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken).ConfigureAwait(false);
            }
        }

        public override Task StopAsync(CancellationToken stoppingToken)
        {
            return Task.CompletedTask;
        }
    }
}
