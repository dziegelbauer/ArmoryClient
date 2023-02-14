using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class DpsDTO
{
    [JsonProperty("value")] public double Value { get; set; }
    [JsonProperty("display_string")] public string DisplayString { get; set; }
}