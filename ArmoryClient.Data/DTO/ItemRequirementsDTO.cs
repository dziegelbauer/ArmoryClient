using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ItemRequirementsDTO
{
    [JsonProperty("level")] public LevelRequirementsDTO Level { get; set; }
    [JsonProperty("playable_classes")] public ClassRequirementsDTO Class { get; set; }
}