using System.Threading.Tasks;
using ArmoryClient.Data.Repository;
using ArmoryClient.Models;
using ArmoryClient.UI.ViewModel.Interface;

namespace ArmoryClient.UI.ViewModel;

public class CharacterViewModel : ViewModelBase, ICharacterViewModel
{
    private readonly IProfileRepository _profileRepository;

    public CharacterViewModel(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    public EquipmentViewModel EquipmentViewModel { get; set; }
    public AchievementViewModel AchievementViewModel { get; set; }
    public string Name { get; private set; }

    public async Task LoadAsync(string name)
    {
        Name = name;
        var data = await _profileRepository.GetEquipment(Region.NA, "thrall", name);
    }
}