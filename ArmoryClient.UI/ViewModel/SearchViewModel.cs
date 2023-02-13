using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ArmoryClient.Data.Repository;
using ArmoryClient.Models;
using ArmoryClient.UI.ViewModel.Interface;
using Prism.Commands;

namespace ArmoryClient.UI.ViewModel;

public class SearchViewModel : ViewModelBase, ISearchViewModel
{
    private readonly IStaticRepository _staticRepository;

    private string _searchString;

    public SearchViewModel(IStaticRepository staticRepository)
    {
        _staticRepository = staticRepository;
        RealmList = new ObservableCollection<Realm>();

        SearchCommand = new DelegateCommand(OnSearchExecute, OnSearchCanExecute);
    }

    public ObservableCollection<Realm> RealmList { get; set; }
    public ICommand SearchCommand { get; }

    public string SearchString
    {
        get => _searchString;
        set
        {
            _searchString = value;
            OnPropertyChanged();
        }
    }

    public async Task LoadAsync()
    {
        var realmList = await _staticRepository.GetRealms();

        RealmList.Clear();
        foreach (var realm in realmList.OrderBy(r => r.Name))
        {
            RealmList.Add(realm);
        }
    }

    private bool OnSearchCanExecute()
    {
        throw new NotImplementedException();
    }

    private void OnSearchExecute()
    {
        throw new NotImplementedException();
    }
}