using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class DisplayDTO
{
    [JsonProperty("display_string")] public string DisplayString { get; set; }
    [JsonProperty("color")] public ColorDTO Color { get; set; }
}