// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using ArmoryClient.UI.ViewModel;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ArmoryClient.UI;

/// <summary>
///     An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    private readonly MainViewModel _mainViewModel;

    public MainWindow(MainViewModel mainViewModel)
    {
        InitializeComponent();
        _mainViewModel = mainViewModel;
        mainGrid.DataContext = _mainViewModel;
    }

    private async void MainGrid_OnLoaded(object sender, RoutedEventArgs e)
    {
        await _mainViewModel.LoadAsync();
    }
}