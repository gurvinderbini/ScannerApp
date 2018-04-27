using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using ScannerApp.NavigationService;

namespace ScannerApp.ViewModels
{
    public class LoginPageViewModel:BaseViewModel
    {
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        private string _username;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                RaisePropertyChanged();
            }
        }

        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }


        public RelayCommand LoginCommand=>new RelayCommand(Login);

        private void Login()
        {
            NavigationService.NavigateTo(ViewModelLocator.ScannerPage);
        }
    }
}
