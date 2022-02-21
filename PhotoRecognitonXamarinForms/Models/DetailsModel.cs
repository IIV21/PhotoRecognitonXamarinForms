// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;
using System.Collections.Generic;

public class DetailsModel
{
    [JsonProperty("categories")]
    public List<object> Categories { get; set; }

    [JsonProperty("adult")]
    public Adult Adult { get; set; }

    [JsonProperty("color")]
    public Color Color { get; set; }

    [JsonProperty("imageType")]
    public ImageType ImageType { get; set; }

    [JsonProperty("tags")]
    public List<Tag> Tags { get; set; }

    [JsonProperty("description")]
    public Description Description { get; set; }

    [JsonProperty("faces")]
    public List<object> Faces { get; set; }

    [JsonProperty("objects")]
    public List<Object> Objects { get; set; }

    [JsonProperty("brands")]
    public List<object> Brands { get; set; }

    [JsonProperty("requestId")]
    public string RequestId { get; set; }

    [JsonProperty("metadata")]
    public Metadata Metadata { get; set; }

    [JsonProperty("modelVersion")]
    public string ModelVersion { get; set; }
}

