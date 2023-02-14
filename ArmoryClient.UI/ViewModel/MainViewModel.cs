using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ArmoryClient.Data.Repository;
using ArmoryClient.UI.Event;
using ArmoryClient.UI.ViewModel.Interface;
using Prism.Events;

namespace ArmoryClient.UI.ViewModel;

public class MainViewModel
{
    private readonly IStaticRepository _staticRepository;
    private readonly IEventAggregator _eventAggregator;
    private readonly Func<ICharacterViewModel> _characterCreator;

    public MainViewModel(IStaticRepository staticRepository, ISearchViewModel searchViewModel, IEventAggregator eventAggregator, Func<ICharacterViewModel> characterCreator)
    {
        _staticRepository = staticRepository;
        _eventAggregator = eventAggregator;
        _characterCreator = characterCreator;
        SearchViewModel = searchViewModel;
        CharacterList = new();

        _eventAggregator.GetEvent<AfterSearchEvent>()
            .Subscribe(AfterSearchExecute);
    }

    private async void AfterSearchExecute(AfterSearchEventArgs args)
    {
        if (CharacterList.All(c => c.Name != args.SearchName))
        {
            var newCharacter = _characterCreator();
            await newCharacter.LoadAsync(args.SearchName);
            CharacterList.Add(newCharacter);
        }
    }

    public ISearchViewModel SearchViewModel { get; set; }
    public ObservableCollection<ICharacterViewModel> CharacterList { get; set; }

    public async Task LoadAsync()
    {
        await SearchViewModel.LoadAsync();
    }
}