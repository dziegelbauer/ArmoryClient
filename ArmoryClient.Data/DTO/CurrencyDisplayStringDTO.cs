using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class CurrencyDisplayStringDTO
{
    [JsonProperty("header")] public string Header { get; set; }
    [JsonProperty("gold")] public string Gold { get; set; }
    [JsonProperty("silver")] public string Silver { get; set; }
    [JsonProperty("copper")] public string Copper { get; set; }
}