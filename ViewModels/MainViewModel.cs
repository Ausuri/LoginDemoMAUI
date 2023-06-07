using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LoginDemoMAUI.DAL;
using LoginDemoMAUI.Shared;
using LoginDemoMAUI.Views;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginDemoMAUI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private string _userName;
        private string _password;
        private readonly IDataAccess _dataAccess;

        public string UserName { get => _userName; set => SetProperty(ref _userName, value); }
        public string Password { get => _password; set => SetProperty(ref _password, value); }
        public ICommand LoginCommand { get; }

        public MainViewModel(IDataAccess dataAccess)
        {
            LoginCommand = new RelayCommand(LoginAction);
            _dataAccess = dataAccess;
        }

        private async void LoginAction()
        {
            //Request login to server with credentials.
            UserLogin loginRequestCredentials = new UserLogin() { Password = _password, UserName = _userName };
            string jwt = await _dataAccess.LoginRequest(loginRequestCredentials);

            //The server ultimately determines this of course, but the UI should reflect if they're logged in.
            bool isAuthorized = await _dataAccess.IsUserAuthenticated();

            if (isAuthorized)
            {
                var navigation = Shell.Current.Navigation;
                await navigation.PushAsync(new FeedPage(new FeedViewModel()));
            }
        }
    }
}
