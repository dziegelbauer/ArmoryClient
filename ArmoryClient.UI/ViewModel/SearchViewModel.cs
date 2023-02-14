using System.Collections.Generic;
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
    private readonly IEventAggregator _eventAggregator;
    private readonly IStaticRepository _staticRepository;

    private string _searchString;
    private Realm _selectedRealm;
    private LookupItemViewModel _selectedRegion;

    public SearchViewModel(IStaticRepository staticRepository, IEventAggregator eventAggregator)
    {
        _staticRepository = staticRepository;
        _eventAggregator = eventAggregator;
        RealmList = new ObservableCollection<Realm>();
        RegionList = new ObservableCollection<LookupItemViewModel>();

        foreach (var reg in new List<Region> { Region.NA, Region.EU, Region.KR, Region.TW })
        {
            RegionList.Add(new LookupItemViewModel((int)reg, reg.ToString()));
        }

        SearchCommand = new DelegateCommand(OnSearchExecute, OnSearchCanExecute);
    }

    public ObservableCollection<Realm> RealmList { get; set; }
    public ObservableCollection<LookupItemViewModel> RegionList { get; set; }
    public ICommand SearchCommand { get; }

    public Realm SelectedRealm
    {
        get => _selectedRealm;
        set
        {
            _selectedRealm = value;
            OnPropertyChanged();
            ((DelegateCommand)SearchCommand).RaiseCanExecuteChanged();
        }
    }

    public string SearchString
    {
        get => _searchString;
        set
        {
            _searchString = value;
            OnPropertyChanged();
            ((DelegateCommand)SearchCommand).RaiseCanExecuteChanged();
        }
    }

    public LookupItemViewModel SelectedRegion
    {
        get => _selectedRegion;
        set
        {
            _selectedRegion = value;
            OnPropertyChanged();
            ((DelegateCommand)SearchCommand).RaiseCanExecuteChanged();
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
        return !string.IsNullOrEmpty(_searchString)
               && _selectedRealm is not null
               && _selectedRegion is not null;
    }

    private void OnSearchExecute()
    {
        _eventAggregator.GetEvent<AfterSearchEvent>()
            .Publish(new AfterSearchEventArgs
            {
                SearchName = _searchString,
                SearchRealm = _selectedRealm.Slug,
                SearchRegion = Region.NA
            });
    }
}