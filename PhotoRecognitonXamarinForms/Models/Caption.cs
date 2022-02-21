// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

public class Caption
{
    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("confidence")]
    public double Confidence { get; set; }
}

