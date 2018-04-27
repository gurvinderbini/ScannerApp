using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Views;

namespace ScannerApp.ViewModels
{
   public class HomePageViewModel:BaseViewModel
    {
        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
