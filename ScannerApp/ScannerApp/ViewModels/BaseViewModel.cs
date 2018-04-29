using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using ScannerApp.Backend.Apis;

namespace ScannerApp.ViewModels
{
    public class BaseViewModel:ViewModelBase
    {
        public INavigationService NavigationService;

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        #region Properties
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
        #endregion

        #region Backend

        public static LoginDa LoginDa=>new LoginDa();
        public static BarcodeDa BarcodeDa => new BarcodeDa();

        #endregion
    }
}
