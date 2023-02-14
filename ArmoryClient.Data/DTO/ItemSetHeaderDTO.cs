using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ItemSetHeaderDTO
{
    [JsonProperty("key")] public APIUrlDTO APIUrl { get; set; }
    [JsonProperty("id")] public string Id { get; set; }
    [JsonProperty("name")] public string Name { get; set; }
}