using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class EnchantmentSlotDTO
{
    [JsonProperty("id")] public int Id { get; set; }
    [JsonProperty("type")] public string Type { get; set; }
}