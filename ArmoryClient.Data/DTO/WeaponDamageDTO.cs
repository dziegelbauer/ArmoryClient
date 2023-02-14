using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class WeaponDamageDTO
{
    [JsonProperty("min_value")] public int Min { get; set; }
    [JsonProperty("max_value")] public int Max { get; set; }
    [JsonProperty("display_string")] public string DisplayString { get; set; }
    [JsonProperty("damage_class")] public DamageClassDTO DamageClass { get; set; }
}