using System.Threading.Tasks;
using ArmoryClient.Data.Repository;
using ArmoryClient.UI.ViewModel.Interface;

namespace ArmoryClient.UI.ViewModel;

public class MainViewModel
{
    private readonly IStaticRepository _staticRepository;

    public MainViewModel(IStaticRepository staticRepository, ISearchViewModel searchViewModel)
    {
        _staticRepository = staticRepository;
        SearchViewModel = searchViewModel;
    }

    public ISearchViewModel SearchViewModel { get; set; }

    public async Task LoadAsync()
    {
        await SearchViewModel.LoadAsync();
    }
}