// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;
using System.Collections.Generic;

public class Description
{
    [JsonProperty("tags")]
    public List<string> Tags { get; set; }

    [JsonProperty("captions")]
    public List<Caption> Captions { get; set; }
}

