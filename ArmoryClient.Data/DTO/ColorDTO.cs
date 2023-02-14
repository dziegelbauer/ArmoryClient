using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ColorDTO
{
    [JsonProperty("r")] public int Red { get; set; }
    [JsonProperty("g")] public int Green { get; set; }
    [JsonProperty("b")] public int Blue { get; set; }
    [JsonProperty("a")] public double Alpha { get; set; }
}