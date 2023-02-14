using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class APIUrlDTO
{
    [JsonProperty("href")] public string href { get; set; }
}