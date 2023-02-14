﻿using Newtonsoft.Json;

namespace ArmoryClient.Data.DTO;

public class StatTypeDTO
{
    [JsonProperty("type")] public string Type { get; set; }
    [JsonProperty("name")] public string Name { get; set; }
}