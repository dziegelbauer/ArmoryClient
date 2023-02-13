using ArmoryClient.Data.Repository;
using ArmoryClient.UI.ViewModel;
using ArmoryClient.UI.ViewModel.Interface;
using Autofac;

namespace ArmoryClient.UI.Bootstrap;

public class Bootstrapper
{
    public IContainer Bootstrap()
    {
        var builder = new ContainerBuilder();

        builder.RegisterType<StaticRepository>().As<IStaticRepository>();
        builder.RegisterType<SearchViewModel>().As<ISearchViewModel>();
        builder.RegisterType<MainViewModel>().AsSelf();
        builder.RegisterType<MainWindow>().AsSelf();

        return builder.Build();
    }
}