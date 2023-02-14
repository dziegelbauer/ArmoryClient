using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class SellPriceDTO
{
    [JsonProperty("value")] public int Value { get; set; }
    [JsonProperty("display_strings")] public CurrencyDisplayStringDTO DisplayInformation { get; set; }
}