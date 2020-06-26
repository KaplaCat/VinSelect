using System;
using VinSelect.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VinSelect
{
    public partial class App : Application
    {
        static App()
        {
            BuildDependencies();
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static void BuildDependencies()
        {
            Locator.Instance.Build();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
