using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryClient.Data.DTO;

public class APIResponseHeaderDTO
{
    [JsonProperty("self")]
    public Self self { get; set; }
}

public class Self
{
    [JsonProperty("href")]
    public string href { get; set; }
}
