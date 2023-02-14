using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class AttackSpeedDTO
{
    [JsonProperty("value")] public int Value { get; set; }
    [JsonProperty("display_string")] public string DisplayString { get; set; }
}