// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;
using System.Collections.Generic;

public class Color
{
    [JsonProperty("dominantColorForeground")]
    public string DominantColorForeground { get; set; }

    [JsonProperty("dominantColorBackground")]
    public string DominantColorBackground { get; set; }

    [JsonProperty("dominantColors")]
    public List<string> DominantColors { get; set; }

    [JsonProperty("accentColor")]
    public string AccentColor { get; set; }

    [JsonProperty("isBwImg")]
    public bool IsBwImg { get; set; }

    [JsonProperty("isBWImg")]
    public bool IsBWImg { get; set; }
}

