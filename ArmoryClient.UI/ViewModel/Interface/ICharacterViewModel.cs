using System.Threading.Tasks;

namespace ArmoryClient.UI.ViewModel.Interface;

public interface ICharacterViewModel
{
    string Name { get; }
    Task LoadAsync(string name);
}