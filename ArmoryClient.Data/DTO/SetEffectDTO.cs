using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class SetEffectDTO
{
    [JsonProperty("display_string")] public string DisplayString { get; set; }
    [JsonProperty("required_count")] public int RequiredCount { get; set; }
    [JsonProperty("is_active")] public bool Active { get; set; }
}