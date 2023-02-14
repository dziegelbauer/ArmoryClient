using System;
using System.Threading.Tasks;
using ArmoryClient.UI.ViewModel.Interface;

namespace ArmoryClient.UI.ViewModel;

public class CharacterViewModel : ViewModelBase, ICharacterViewModel
{
    public EquipmentViewModel EquipmentViewModel { get; set; }
    public AchievementViewModel AchievementViewModel { get; set; }
    public string Name { get; private set; }

    public async Task LoadAsync(string name)
    {
        Name = name;
        await Task.Delay(0);
    }
}