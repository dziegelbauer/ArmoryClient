using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class APIResponseHeaderDTO
{
    [JsonProperty("self")] public APIUrlDTO ApiUrl { get; set; }
}