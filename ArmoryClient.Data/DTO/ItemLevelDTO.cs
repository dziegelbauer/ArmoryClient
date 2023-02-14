using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ItemLevelDTO
{
    [JsonProperty("value")] public int Value { get; set; }
    [JsonProperty("display")] public string DisplayString { get; set; }
}