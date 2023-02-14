using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ItemDTO
{
    [JsonProperty("item")] public ItemHeaderDTO ItemHeader { get; set; }
    [JsonProperty("sockets")] public List<SocketDTO> Sockets { get; set; }
    [JsonProperty("slot")] public ItemSlotDTO Slot { get; set; }
    [JsonProperty("quantity")] public int Quantity { get; set; }
    [JsonProperty("context")] public int Context { get; set; }
    [JsonProperty("bonus_list")] public List<int> BonusList { get; set; }
    [JsonProperty("quality")] public QualityDTO Quality { get; set; }
    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("modified_appearance_id")]
    public int ModifiedAppearanceId { get; set; }

    [JsonProperty("media")] public MediaHeaderDTO MediaHeader { get; set; }
    [JsonProperty("item_class")] public ItemClassDTO ItemClass { get; set; }
    [JsonProperty("item_subclass")] public ItemSubclassDTO ItemSubclass { get; set; }
    [JsonProperty("inventory_type")] public ItemSlotDTO InventoryType { get; set; }
    [JsonProperty("binding")] public BindingDTO Binding { get; set; }
    [JsonProperty("armor")] public ArmorDTO Armor { get; set; }
    [JsonProperty("stats")] public List<StatDTO> Stats { get; set; }
    [JsonProperty("sell_price")] public SellPriceDTO SellPrice { get; set; }
    [JsonProperty("requirements")] public ItemRequirementsDTO Requirements { get; set; }
    [JsonProperty("set")] public ItemSetDTO Set { get; set; }
    [JsonProperty("level")] public ItemLevelDTO Level { get; set; }
    [JsonProperty("transmog")] public TransmogDTO Transmog { get; set; }
    [JsonProperty("durability")] public DurabilityDTO Durability { get; set; }
    [JsonProperty("name_description")] public ItemNameDescriptionDTO NameDescription { get; set; }
    [JsonProperty("unique_equipped")] public string UniqueEquipped { get; set; }
    [JsonProperty("is_subclass_hidden")] public bool SubclassHidden { get; set; }
    [JsonProperty("enchantments")] public List<ItemEnchantmentDTO> Enchantments { get; set; }
    [JsonProperty("limit_category")] public string LimitCategory { get; set; }
    [JsonProperty("spells")] public List<ItemSpellDTO> Spells { get; set; }
    [JsonProperty("description")] public string Description { get; set; }
    [JsonProperty("weapon")] public WeaponDTO WeaponInfo { get; set; }
}