using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class RealmDTO
{
    [JsonProperty("id")] public int Id { get; set; }
    [JsonProperty("name")] public string Name { get; set; }
    [JsonProperty("slug")] public string Slug { get; set; }
}