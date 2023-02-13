using System;
using System.Threading.Tasks;
using ArmoryClient.UI.ViewModel.Interface;

namespace ArmoryClient.UI.ViewModel;

public class CharacterViewModel : ViewModelBase, ICharacterViewModel
{
    public EquipmentViewModel EquipmentViewModel { get; set; }
    public AchievementViewModel AchievementViewModel { get; set; }

    public Task LoadAsync()
    {
        throw new NotImplementedException();
    }
}