using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TGTG.Api.Core.Utils
{
    internal class InternalHttpClient : IDisposable
    {
        private readonly HttpClient _httpClient;

        internal TimeSpan Timeout
        {
            get => _httpClient.Timeout;
            set => _httpClient.Timeout = value;
        }

        internal InternalHttpClient()
        {
            _httpClient = CreateHttpClient();
        }

        internal async Task<TResponse> PostAsync<TResponse, TRequest>(string url, TRequest request, string token)
        {
            var response = await PostInternalAsync(url, request, token);
            var responseJson = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(responseJson);
        }

        internal async Task PostAsync<TRequest>(string url, TRequest request, string token)
        {
            await PostInternalAsync(url, request, token);
        }

        private async Task<HttpResponseMessage> PostInternalAsync<TRequest>(string url, TRequest request, string token)
        {
            var requestJson = JsonConvert.SerializeObject(request);
            var requestMessage = CreateMessage(url, requestJson, token);
            var response = await _httpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseContentRead);

            response.EnsureSuccessStatusCode();

            return response;
        }

        private static HttpRequestMessage CreateMessage(string url, string json, string token)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, url) { Content = new StringContent(json) };

            message.Headers.AcceptLanguage.TryParseAdd("en-GB");
            message.Headers.UserAgent.TryParseAdd("TGTG/21.1.3 Dalvik/2.1.0 (Linux; U; Android 11; Pixel 4 XL Build/RQ1A.210205.004)");
            message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            if (!string.IsNullOrWhiteSpace(token))
                message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            return message;
        }

        private static HttpClient CreateHttpClient()
        {
            return new HttpClient
            {
                BaseAddress = new Uri("https://apptoogoodtogo.com/api/"),
                Timeout = TimeSpan.FromMinutes(1)
            };
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}