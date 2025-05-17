using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingEconomicsViewer.Data;


namespace TradingEconomicsViewer.Business
{
    public class EconomicsService : IDisposable
    {
        private readonly EconomicsRepository _repository;
        private bool _disposed = false;

        public EconomicsService(string apiKey)
        {
            _repository = new EconomicsRepository(apiKey);
        }

        public async Task<List<EconomicIndicator>> GetCountryEconomicDataAsync(string country)
        {
            return await _repository.GetCountryDataAsync(country);
        }

        public async Task<List<string>> GetAllIndicatorsAsync()
        {
            return await _repository.GetIndicatorsAsync();
        }

        public async Task<List<EconomicIndicator>> GetFilteredDataForCountryAsync(string country, string indicator)
        {
            var data = await GetCountryEconomicDataAsync(country);
            return data
                .Where(d => d.Category.Equals(indicator, System.StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(d => d.LatestValueDate ?? DateTime.MinValue) // Handle nullable LatestValueDate
                .ToList();
        }

        public async Task<double?> GetIndicatorValueForCountryAsync(string country, string indicator)
        {
            var data = await GetCountryEconomicDataAsync(country);
            var latestIndicator = data
                .Where(d => d.Category.Equals(indicator, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(d => d.LatestValueDate ?? DateTime.MinValue) // Handle nullable LatestValueDate
                .FirstOrDefault();
            return latestIndicator?.LatestValue;
        }

        public List<string> GetCommonDates(List<EconomicIndicator> data1, List<EconomicIndicator> data2)
        {
            return data1.Where(d => d.LatestValueDate.HasValue)
                        .Select(d => d.LatestValueDate.Value)
                        .Intersect(data2.Where(d => d.LatestValueDate.HasValue)
                                      .Select(d => d.LatestValueDate.Value))
                        .OrderByDescending(d => d)
                        .Take(10)
                        .Select(d => d.ToString("yyyy-MM-dd"))
                        .ToList();
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
                    _repository.Dispose();
                }
                _disposed = true;
            }
        }
    }
}

