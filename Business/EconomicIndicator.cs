using Newtonsoft.Json;
using System;


namespace TradingEconomicsViewer.Business
{
    public class EconomicIndicator
    {
        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("LatestValueDate")]
        public DateTime? LatestValueDate { get; set; }

        [JsonProperty("LatestValue")]
        public double? LatestValue { get; set; }

        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("SourceURL")]
        public string SourceURL { get; set; }

        [JsonProperty("Unit")]
        public string Unit { get; set; }

        [JsonProperty("URL")]
        public string URL { get; set; }

        [JsonProperty("CategoryGroup")]
        public string CategoryGroup { get; set; }

        [JsonProperty("Adjustment")]
        public string Adjustment { get; set; }

        [JsonProperty("Frequency")]
        public string Frequency { get; set; }

        [JsonProperty("HistoricalDataSymbol")]
        public string HistoricalDataSymbol { get; set; }

        [JsonProperty("CreateDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("FirstValueDate")]
        public DateTime? FirstValueDate { get; set; }

        [JsonProperty("PreviousValue")]
        public double? PreviousValue { get; set; }

        [JsonProperty("PreviousValueDate")]
        public DateTime? PreviousValueDate { get; set; }
    }
}
