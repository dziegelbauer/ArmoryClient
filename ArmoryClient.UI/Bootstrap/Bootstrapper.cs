using ArmoryClient.Data.Repository;
using ArmoryClient.UI.ViewModel;
using ArmoryClient.UI.ViewModel.Interface;
using Autofac;
using Prism.Events;

namespace ArmoryClient.UI.Bootstrap;

public class Bootstrapper
{
    public IContainer Bootstrap()
    {
        var builder = new ContainerBuilder();

        builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
        builder.RegisterType<StaticRepository>().As<IStaticRepository>();
        builder.RegisterType<SearchViewModel>().As<ISearchViewModel>();
        builder.RegisterType<CharacterViewModel>().As<ICharacterViewModel>();
        builder.RegisterType<MainViewModel>().AsSelf();
        builder.RegisterType<MainWindow>().AsSelf();

        return builder.Build();
    }
}