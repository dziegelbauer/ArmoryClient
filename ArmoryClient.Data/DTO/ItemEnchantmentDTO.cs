using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ItemEnchantmentDTO
{
    [JsonProperty("display_string")] public string DisplayString { get; set; }
    [JsonProperty("source_item")] public ItemHeaderDTO SourceITem { get; set; }
    [JsonProperty("enchantment_id")] public int Id { get; set; }
    [JsonProperty("enchantment_slot")] public EnchantmentSlotDTO Slot { get; set; }
}