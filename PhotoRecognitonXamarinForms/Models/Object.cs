// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

public class Object
{
    [JsonProperty("rectangle")]
    public Rectangle Rectangle { get; set; }

    [JsonProperty("object")]
    public string Object2 { get; set; }

    [JsonProperty("confidence")]
    public double Confidence { get; set; }

    [JsonProperty("parent")]
    public Parent2 Parent { get; set; }
}

