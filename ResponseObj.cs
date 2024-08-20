using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("originalWords")]
    public int originalWords { get; set; }

    [JsonProperty("summaryWords")]
    public int summaryWords { get; set; }

    [JsonProperty("percentDifference")]
    public double percentDifference { get; set; }

    [JsonProperty("summary")]
    public string summary { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
