using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class TransmogDTO
{
    [JsonProperty("item")] public ItemHeaderDTO ItemHeader { get; set; }

    [JsonProperty("modified_appearance_id")]
    public int ModifiedAppearanceId { get; set; }

    [JsonProperty("display_string")] public string DisplayString { get; set; }
}