using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ArmoryClient.Data.Repository;
using ArmoryClient.Models;
using ArmoryClient.UI.Event;
using ArmoryClient.UI.ViewModel.Interface;
using Prism.Commands;
using Prism.Events;

namespace ArmoryClient.UI.ViewModel;

public class SearchViewModel : ViewModelBase, ISearchViewModel
{
    private readonly IStaticRepository _staticRepository;

    private string _searchString;
    private readonly IEventAggregator _eventAggregator;
    private Realm _selectedRealm;

    public SearchViewModel(IStaticRepository staticRepository, IEventAggregator eventAggregator)
    {
        _staticRepository = staticRepository;
        _eventAggregator = eventAggregator;
        RealmList = new ObservableCollection<Realm>();

        SearchCommand = new DelegateCommand(OnSearchExecute, OnSearchCanExecute);
    }

    public ObservableCollection<Realm> RealmList { get; set; }
    public ICommand SearchCommand { get; }

    public Realm SelectedRealm
    {
        get => _selectedRealm;
        set
        {
            _selectedRealm = value;
            OnPropertyChanged();
        }
    }

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
        return true;
    }

    private void OnSearchExecute()
    {
        _eventAggregator.GetEvent<AfterSearchEvent>()
            .Publish(new AfterSearchEventArgs()
            {
                SearchName = _searchString,
                SearchRealm = _selectedRealm.Slug,
                SearchRegion = Region.NA,
            });
    }
}