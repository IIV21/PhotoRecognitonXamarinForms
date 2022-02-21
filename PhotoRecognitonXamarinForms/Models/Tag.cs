// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

public class Tag
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("confidence")]
    public double Confidence { get; set; }
}

