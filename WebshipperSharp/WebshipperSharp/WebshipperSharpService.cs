using Polly.Retry;
using Microsoft.Extensions.Logging;
using Polly;
using Newtonsoft.Json;
using WebshipperSharp.Entities.Printers;
using WebshipperSharp.Entities.PrinterJobs;
using WebshipperSharp.Entities.PrinterClients;

namespace WebshipperSharp
{
    public interface IWebshipperSharpService
    {
        Task<Printer?> GetPrinterAsync(long id);
        Task<Printer?> GetPrinterByPrinterJobIdAsync(long id);
        Task<PrinterClientIdBody?> GetPrinterClientAsync(long id);
        Task<PrinterClientIdBody?> GetPrinterClientByOrderIdAsync(long id);
        Task<PrinterClientIdBody?> GetPrinterClientByPrinterJobIdAsync(long id);
        Task<PrinterClientIdBody?> GetPrinterClientByShipmentIdAsync(long id);
        Task<PrinterClientsBody?> GetPrinterClientsAsync();
        Task<PrinterJobIdBody?> GetPrinterJobAsync(long id);
    }

    public class WebshipperSharpService : IWebshipperSharpService
    {
        internal readonly AsyncRetryPolicy<HttpResponseMessage> asyncRetryPolicy;
        internal readonly HttpClient httpClient;

        private readonly ILogger<WebshipperSharpService> _logger;

        public WebshipperSharpService(ILogger<WebshipperSharpService> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;

            httpClient = httpClientFactory.CreateClient("WebshipperSharpClient");

            asyncRetryPolicy = Policy
                .Handle<HttpRequestException>(HandleHttpRequestException)
                .OrResult<HttpResponseMessage>(HandleHttpResponseMessage)
                //.HandleResult<HttpResponseMessage>(HandleHttpResponseMessage)
                .WaitAndRetryForeverAsync(retryAttempt => TimeSpan.FromSeconds(3));
        }
        private bool HandleHttpRequestException(HttpRequestException httpRequestException)
        {
            _logger.LogError("HttpRequestException", httpRequestException);

            return true;
        }

        private bool HandleHttpResponseMessage(HttpResponseMessage httpResponseMessage)
        {
            //var test = httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            if (httpResponseMessage.IsSuccessStatusCode) return false;

            LogErrors(httpResponseMessage);

            if ((int)httpResponseMessage.StatusCode > 399 && (int)httpResponseMessage.StatusCode < 500)
            {
                throw new ArgumentException(httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            }

            return true;
        }
        private void LogErrors(HttpResponseMessage httpResponseMessage)
        {
            _logger.LogError(httpResponseMessage.RequestMessage?.ToString());
            _logger.LogError(httpResponseMessage.ToString());
            _logger.LogError(httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }

        public async Task<Printer?> GetPrinterAsync(long id) => await PrinterExtension.GetPrinterAsync(this, id);
        public async Task<Printer?> GetPrinterByPrinterJobIdAsync(long id) => await PrinterExtension.GetPrinterByPrinterJobIdAsync(this, id);
        public async Task<PrinterJobIdBody?> GetPrinterJobAsync(long id) => await PrinterJobExtension.GetPrinterJobAsync(this, id);
        public async Task<PrinterClientsBody?> GetPrinterClientsAsync() => await PrinterClientExtension.GetPrinterClientsAsync(this);
        public async Task<PrinterClientIdBody?> GetPrinterClientAsync(long id) => await PrinterClientExtension.GetPrinterClientAsync(this, id);
        public async Task<PrinterClientIdBody?> GetPrinterClientByPrinterJobIdAsync(long id) => await PrinterClientExtension.GetPrinterClientByPrinterJobIdAsync(this, id);
        public async Task<PrinterClientIdBody?> GetPrinterClientByShipmentIdAsync(long id) => await PrinterClientExtension.GetPrinterClientByShipmentIdAsync(this, id);
        public async Task<PrinterClientIdBody?> GetPrinterClientByOrderIdAsync(long id) => await PrinterClientExtension.GetPrinterClientByOrderIdAsync(this, id);
    }
}
