// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

public class ImageType
{
    [JsonProperty("clipArtType")]
    public int ClipArtType { get; set; }

    [JsonProperty("lineDrawingType")]
    public int LineDrawingType { get; set; }
}

