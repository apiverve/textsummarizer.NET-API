using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("originalWords")]
        public int OriginalWords { get; set; }

        [JsonProperty("summaryWords")]
        public int SummaryWords { get; set; }

        [JsonProperty("percentDifference")]
        public double PercentDifference { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
