using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class SocketDTO
{
    [JsonProperty("socket_type")] public SocketTypeDTO SocketType { get; set; }
    [JsonProperty("item")] public ItemHeaderDTO SockettedItem { get; set; }
    [JsonProperty("display_string")] public string DisplayString { get; set; }
    [JsonProperty("media")] public MediaHeaderDTO Media { get; set; }
}