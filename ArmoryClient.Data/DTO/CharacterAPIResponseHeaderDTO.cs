using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class CharacterAPIResponseHeaderDTO
{
    [JsonProperty("name")] public string Name { get; set; }
    [JsonProperty("id")] public int Id { get; set; }
    [JsonProperty("realm")] public RealmDTO Realm { get; set; }
}