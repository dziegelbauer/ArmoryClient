using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class StatDTO
{
    [JsonProperty("type")] public StatTypeDTO StatType { get; set; }
    [JsonProperty("value")] public int Value { get; set; }
    [JsonProperty("display")] public DisplayDTO DisplayInformation { get; set; }
    [JsonProperty("is_negated")] public bool IsNegated { get; set; }
    [JsonProperty("is_equip_bonus")] public bool IsEquipBonus { get; set; }
}