// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

public class Parent2
{
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("confidence")]
    public double Confidence { get; set; }

    [JsonProperty("parent")]
    public Parent2 Parent { get; set; }
}

