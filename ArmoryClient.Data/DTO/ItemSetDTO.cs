using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ItemSetDTO
{
    [JsonProperty("item_set")] public ItemSetHeaderDTO ItemSet { get; set; }
    [JsonProperty("items")] public List<SetItemSummaryDTO> Items { get; set; }
    [JsonProperty("effects")] public List<SetEffectDTO> Effects { get; set; }
    [JsonProperty("display_string")] public string DisplayString { get; set; }
}