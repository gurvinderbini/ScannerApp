using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace ScannerApp.ViewModels
{
    public class BaseViewModel:ViewModelBase
    {
        public INavigationService NavigationService;

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        private bool _layoutVisibility;

        public bool LayoutVisibility
        {
            get => _layoutVisibility;
            set
            {
                _layoutVisibility = value;
                RaisePropertyChanged();
            }
        }
    }
}
