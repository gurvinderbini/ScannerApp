using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Views;

namespace ScannerApp.ViewModels
{
    public class BaseViewModel
    {
        public INavigationService NavigationService;

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
