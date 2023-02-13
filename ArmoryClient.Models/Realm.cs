using Newtonsoft.Json;

namespace ArmoryClient.Models;

public class Realm
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("slug")] public string Slug { get; set; }
}