using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class LevelRequirementsDTO
{
    [JsonProperty("value")] public int Value { get; set; }
    [JsonProperty("display")] public string DisplayString { get; set; }
}