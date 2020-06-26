using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VinSelect.ViewModels.Base;
using VinSelect.ViewModels.Connexion;

namespace VinSelect.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Binding Command
        public ICommand CmdOpenConnexionPage => new AsyncCommand(TaskOpenConnexionPage);
        #endregion

        #region Navigation Task
        Task TaskOpenConnexionPage() => NavigationService.NavigateToAsync<ConnexionViewModel>(true);
        #endregion
    }
}
