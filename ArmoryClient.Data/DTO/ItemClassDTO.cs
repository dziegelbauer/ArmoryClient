using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ItemClassDTO
{
    [JsonProperty("key")] public APIUrlDTO ApiUrl { get; set; }
    [JsonProperty("name")] public string Name { get; set; }
    [JsonProperty("id")] public int Id { get; set; }
}