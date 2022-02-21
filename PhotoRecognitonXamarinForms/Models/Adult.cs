// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

public class Adult
{
    [JsonProperty("isAdultContent")]
    public bool IsAdultContent { get; set; }

    [JsonProperty("isRacyContent")]
    public bool IsRacyContent { get; set; }

    [JsonProperty("isGoryContent")]
    public bool IsGoryContent { get; set; }

    [JsonProperty("adultScore")]
    public double AdultScore { get; set; }

    [JsonProperty("racyScore")]
    public double RacyScore { get; set; }

    [JsonProperty("goreScore")]
    public double GoreScore { get; set; }
}

