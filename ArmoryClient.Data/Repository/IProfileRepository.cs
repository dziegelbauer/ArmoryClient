using System.Threading.Tasks;
using ArmoryClient.Models;

namespace ArmoryClient.Data.Repository;

public interface IProfileRepository
{
    Task<CharacterEquipment?> GetEquipment(Region reg, string realmSlug, string character);
}