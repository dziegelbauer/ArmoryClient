using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ArmoryClient.Data.DTO;
using ArmoryClient.Models;
using Newtonsoft.Json;

namespace ArmoryClient.Data.Repository;

public class StaticRepository : IStaticRepository
{
    public async Task<IEnumerable<Realm>> GetRealms()
    {
        //var mockData = await File.ReadAllTextAsync(@"C:\Users\dzieg\Documents\projects\cs\ArmoryClient\ArmoryClient.Data\realms.json");
        var mockData =
            await File.ReadAllTextAsync(@"C:\Users\dzieg\projects\ArmoryClient\ArmoryClient.Data\realms.json");

        var response = JsonConvert.DeserializeObject<RealmListAPIResponseDTO>(mockData);

        return response.Realms;
    }
}