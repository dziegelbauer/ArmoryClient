using System.IO;
using System.Threading.Tasks;
using ArmoryClient.Data.DTO;
using ArmoryClient.Data.Utility;
using ArmoryClient.Models;
using Newtonsoft.Json;

namespace ArmoryClient.Data.Repository;

public class ProfileRepository : IProfileRepository
{
    public async Task<CharacterEquipment> GetEquipment(Region reg, string realmSlug, string character)
    {
        var mockData =
            await File.ReadAllTextAsync(@"C:\Users\dzieg\projects\ArmoryClient\ArmoryClient.Data\equip.json");

        var response = JsonConvert.DeserializeObject<CharacterEquipmentAPIResponseDTO>(mockData);

        return ModelBuilder.EquipmentFromItems(ModelBuilder.ItemsFromDTOs(response));
    }
}