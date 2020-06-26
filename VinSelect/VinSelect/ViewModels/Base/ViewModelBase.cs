using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinSelect.Services.Database;
using VinSelect.Services.Dialog;
using VinSelect.Services.Navigation;

namespace VinSelect.ViewModels.Base
{
    public abstract class ViewModelBase : MvvmHelpers.BaseViewModel
    {
        protected readonly INavigationService NavigationService;
        protected readonly IDialogService DialogService;
        protected readonly IDatabaseService DatabaseService;

        public ViewModelBase()
        {
            DialogService = Locator.Instance.Resolve<IDialogService>();
            NavigationService = Locator.Instance.Resolve<INavigationService>();
            DatabaseService = Locator.Instance.Resolve<IDatabaseService>();
        }

        public virtual Task InitializeAsync(object navigationData) => Task.FromResult(false);
    }
}
