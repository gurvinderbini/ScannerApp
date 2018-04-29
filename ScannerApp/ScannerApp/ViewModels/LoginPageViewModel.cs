using System;
using System.Collections.Generic;
using System.Text;
using Acr.UserDialogs;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using ScannerApp.Backend.Apis;
using ScannerApp.NavigationService;
using ScannerApp.Utils;

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

        private new async void Login()
        {
            if (String.IsNullOrEmpty(Password)) return;
            UserDialogs.Instance.ShowLoading();
            var result=   await LoginDa.LoginTask(Password);
            if (!String.IsNullOrEmpty(result.token))
            {
                Settings.SessionCode = result.token;
                Settings.EmployeeID =Convert.ToString(result.employee.id);
                Settings.StationID = "1";
                NavigationService.NavigateTo(ViewModelLocator.ScannerPage);
            }
            UserDialogs.Instance.HideLoading();
        }
    }
}
