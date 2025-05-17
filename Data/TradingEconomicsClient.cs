using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TradingEconomicsViewer.Data
{
    public class TradingEconomicsClient : IDisposable
    {
        // Static HttpClient shared by all instances
        private static readonly HttpClient _httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(30)
        };

        private readonly string _apiKey;
        private bool _disposed = false;

        public TradingEconomicsClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<string> GetCountryDataAsync(string country)
        {
            var url = $"https://api.tradingeconomics.com/country/{country}?c={_apiKey}";

            int retryCount = 0;
            const int maxRetries = 3;
            const int retryDelayMs = 1000;

            while (true)
            {
                try
                {
                    using (var response = await _httpClient.GetAsync(url))
                    {
                        response.EnsureSuccessStatusCode();
                        return await response.Content.ReadAsStringAsync();
                    }
                }
                catch (HttpRequestException ex) when (ex.Message.Contains("409") && retryCount < maxRetries)
                {
                    // Wait before retrying on 409 Conflict
                    retryCount++;
                    await Task.Delay(retryDelayMs * retryCount);

                    if (retryCount >= maxRetries)
                        throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public async Task<string> GetIndicatorsAsync()
        {
            var url = $"https://api.tradingeconomics.com/indicators?c={_apiKey}";

            int retryCount = 0;
            const int maxRetries = 3;
            const int retryDelayMs = 1000;

            while (true)
            {
                try
                {
                    using (var response = await _httpClient.GetAsync(url))
                    {
                        response.EnsureSuccessStatusCode();
                        return await response.Content.ReadAsStringAsync();
                    }
                }
                catch (HttpRequestException ex) when (ex.Message.Contains("409") && retryCount < maxRetries)
                {
                    // Wait before retrying on 409 Conflict
                    retryCount++;
                    await Task.Delay(retryDelayMs * retryCount);

                    if (retryCount >= maxRetries)
                        throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;
            }
        }
    }
}

