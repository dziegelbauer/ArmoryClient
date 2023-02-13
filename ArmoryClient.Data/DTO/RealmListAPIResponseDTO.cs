using ArmoryClient.Models;
using Microsoft.UI.Xaml.Shapes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryClient.Data.DTO;
public class RealmListAPIResponseDTO
{
    [JsonProperty("_links")]
    public APIResponseHeaderDTO Header { get; set; }
    public List<Realm> Realms { get; set; }
}
