using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Vuffeli.Net.Worker.Library.Tests.Fixtures;
using WebshipperSharp;
using WebshipperSharp.Endpoints.PrinterClients;
using Xunit;

namespace Vuffeli.Net.Worker.Library.Tests.ClientTests.Customers
{
    public class WebshipperSharpServiceTests
    {
        private readonly TestFixture _testFixture;
        private readonly WebshipperSharpService _webshipperSharpService;

        public WebshipperSharpServiceTests()
        {
            _testFixture = new TestFixture();
            _webshipperSharpService = _testFixture.ServiceProvider.GetRequiredService<WebshipperSharpService>();
        }

        [Fact]
        public async Task TestGetPrinterClientAsyncIdExists()
        {
            var test = await _webshipperSharpService.GetPrinterClientAsync(4);

            Assert.NotNull(test);
            Assert.NotNull(test.Data.Attributes.Alias);
        }


        [Fact]
        public async Task TestGetPrinterClientAsyncIdDoesNotExist()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () => await _webshipperSharpService.GetPrinterClientAsync(-99999));
        }

        [Fact]
        public async Task TestGetPrinterClientByShipmentIdAsync()
        {
            var test = await _webshipperSharpService.GetPrinterClientByShipmentIdAsync(1);

            Assert.NotNull(test);
        }
    }
}
