using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TradingEconomicsViewer.Business;


namespace TradingEconomicsViewer.Data
{
    public class EconomicsRepository : IDisposable
    {
        private readonly TradingEconomicsClient _client;
        private bool _disposed = false;

        public EconomicsRepository(string apiKey)
        {
            _client = new TradingEconomicsClient(apiKey);
        }

        public async Task<List<EconomicIndicator>> GetCountryDataAsync(string country)
        {
            var json = await _client.GetCountryDataAsync(country);
            return JsonConvert.DeserializeObject<List<EconomicIndicator>>(json);
        }

        public async Task<List<string>> GetIndicatorsAsync()
        {
            var json = await _client.GetIndicatorsAsync();
            var indicators = JsonConvert.DeserializeObject<List<dynamic>>(json);
            var categories = new HashSet<string>();
            foreach (var indicator in indicators)
            {
                if (indicator.Category != null)
                {
                    categories.Add((string)indicator.Category);
                }
            }
            return new List<string>(categories);
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
                if (disposing)
                {
                    _client.Dispose();
                }
                _disposed = true;
            }
        }
    }
}

