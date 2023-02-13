// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using ArmoryClient.UI.Bootstrap;
using Autofac;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ArmoryClient.UI;

/// <summary>
///     Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : Application
{
    private Window m_window;

    /// <summary>
    ///     Initializes the singleton application object.  This is the first line of authored code
    ///     executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
        InitializeComponent();
    }

    /// <summary>
    ///     Invoked when the application is launched.
    /// </summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        var bootstrapper = new Bootstrapper();
        var container = bootstrapper.Bootstrap();
        m_window = container.Resolve<MainWindow>();
        m_window.Activate();
    }
}