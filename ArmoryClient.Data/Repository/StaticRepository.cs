using ArmoryClient.Data.DTO;
using ArmoryClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryClient.Data.Repository;
public class StaticRepository : IStaticRepository
{
    public async Task<IEnumerable<Realm>> GetRealms()
    {
        var mockData = await File.ReadAllTextAsync(@"C:\Users\dzieg\projects\ArmoryClient\ArmoryClient.Data\realms.json");

        var response = JsonConvert.DeserializeObject<RealmListAPIResponseDTO>(mockData);

        return response.Realms;
    }
}
