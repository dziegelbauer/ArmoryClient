using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class SetItemSummaryDTO
{
    [JsonProperty("item")] public ItemHeaderDTO Item { get; set; }
    [JsonProperty("is_equipped")] public bool Equipped { get; set; }
}