using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ArmoryClient.Data.Repository;
using ArmoryClient.Models;
using ArmoryClient.UI.ViewModel.Interface;

namespace ArmoryClient.UI.ViewModel;

public class SearchViewModel : ViewModelBase, ISearchViewModel
{
    private readonly IStaticRepository _staticRepository;

    public SearchViewModel(IStaticRepository staticRepository)
    {
        _staticRepository = staticRepository;
        RealmList = new ObservableCollection<Realm>();
    }

    public ObservableCollection<Realm> RealmList { get; set; }

    public async Task LoadAsync()
    {
        var realmList = await _staticRepository.GetRealms();

        RealmList.Clear();
        foreach (var realm in realmList.OrderBy(r => r.Name))
        {
            RealmList.Add(realm);
        }
    }
}