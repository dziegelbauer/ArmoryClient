using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ItemSlotDTO
{
    [JsonProperty("type")] public string Type { get; set; }
    [JsonProperty("name")] public string Name { get; set; }
}