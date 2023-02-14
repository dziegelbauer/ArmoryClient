using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ItemSpellDTO
{
    [JsonProperty("spell")] public ItemSpellHeaderDTO Spell { get; set; }
    [JsonProperty("description")] public string Description { get; set; }
}