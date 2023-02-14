using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class MediaHeaderDTO
{
    [JsonProperty("key")] public APIUrlDTO ApiUrl { get; set; }
    [JsonProperty("id")] public int Id { get; set; }
}