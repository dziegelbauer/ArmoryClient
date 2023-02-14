using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class ClassRequirementsDTO
{
    [JsonProperty("links")] public List<PlayableClassDTO> Classes { get; set; }
    [JsonProperty("display_string")] public string DisplayString { get; set; }
}