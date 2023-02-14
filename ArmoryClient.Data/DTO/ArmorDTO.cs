using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ArmorDTO
{
    [JsonProperty("value")] public int Value { get; set; }
    [JsonProperty("display")] public DisplayDTO DisplayInformation { get; set; }
}