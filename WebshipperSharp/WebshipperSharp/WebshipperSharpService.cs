using Polly.Retry;
using Microsoft.Extensions.Logging;
using Polly;

namespace WebshipperSharp
{
    public class WebshipperSharpService
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
    }
}
