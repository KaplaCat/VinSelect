using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using VinSelect.Services.Database;
using VinSelect.Services.Dialog;
using VinSelect.Services.Navigation;
using VinSelect.ViewModels.Connexion;

namespace VinSelect.ViewModels.Base
{
    public class Locator
    {
        Autofac.IContainer container;
        ContainerBuilder containerBuilder;

        public static Locator Instance { get; } = new Locator();

        public Locator()
        {
            containerBuilder = new ContainerBuilder();

            // Services
            containerBuilder.RegisterType<DialogService>().As<IDialogService>();
            containerBuilder.RegisterType<NavigationService>().As<INavigationService>();
            containerBuilder.RegisterType<DatabaseService>().As<IDatabaseService>();

            containerBuilder.RegisterType<MainViewModel>();

            // Connexion page
            containerBuilder.RegisterType<ConnexionViewModel>();

        }

        public T Resolve<T>() => container.Resolve<T>();

        public object Resolve(Type type) => container.Resolve(type);

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface => containerBuilder.RegisterType<TImplementation>().As<TInterface>();

        public void Register<T>() where T : class => containerBuilder.RegisterType<T>();

        public void Build() => container = containerBuilder.Build();
    }
}
