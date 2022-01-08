using Polly.Retry;
using Microsoft.Extensions.Logging;
using Polly;
using System.Net.Http;

namespace WebshipperSharp.Services
{
    public class WebshipperSharpService
    {
        internal readonly AsyncRetryPolicy<HttpResponseMessage> asyncRetryPolicy;
        internal readonly HttpClient httpClient;

        private readonly ILogger<WebshipperSharpService> _logger;

        public WebshipperSharpService(ILogger<WebshipperSharpService> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;

            httpClient = httpClientFactory.CreateClient();

            asyncRetryPolicy = Policy
                .Handle<HttpRequestException>(HandleHttpRequestException)
                .OrResult<HttpResponseMessage>(HandleHttpResponseMessage)
                .WaitAndRetryForeverAsync(retryAttempt => TimeSpan.FromSeconds(3));
        }
        private bool HandleHttpRequestException(HttpRequestException httpRequestException)
        {
            _logger.LogError("HttpRequestException", httpRequestException);

            return true;
        }

        private bool HandleHttpResponseMessage(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.IsSuccessStatusCode) return false;

            LogErrors(httpResponseMessage);

            return true;
        }
        private void LogErrors(HttpResponseMessage httpResponseMessage)
        {
            _logger.LogError(httpResponseMessage.RequestMessage.ToString());
            _logger.LogError(httpResponseMessage.ToString());
            _logger.LogError(httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }
    }
}
