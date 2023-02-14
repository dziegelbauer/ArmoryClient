using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class WeaponDTO
{
    [JsonProperty("damage")] public WeaponDamageDTO Damage { get; set; }
    [JsonProperty("attack_speed")] public AttackSpeedDTO Speed { get; set; }
    [JsonProperty("dps")] public DpsDTO DPS { get; set; }
}