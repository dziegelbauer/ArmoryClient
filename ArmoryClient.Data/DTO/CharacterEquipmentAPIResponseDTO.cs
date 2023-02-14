using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class CharacterEquipmentAPIResponseDTO
{
    [JsonProperty("_links")] public APIResponseHeaderDTO Header { get; set; }
    [JsonProperty("character")] public CharacterAPIResponseHeaderDTO Character { get; set; }
    [JsonProperty("equipped_items")] public List<ItemDTO> Equipment { get; set; }
    [JsonProperty("equipped_item_sets")] public List<ItemSetDTO> EquipmentSets { get; set; }
}