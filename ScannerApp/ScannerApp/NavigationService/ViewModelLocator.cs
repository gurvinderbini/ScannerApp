using System;
using System.Collections.Generic;
using System.Text;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using ScannerApp.ViewModels;
using ScannerApp.Views;

namespace ScannerApp.NavigationService
{
   public class ViewModelLocator
    {
        public const string LoginPage = "LoginPage";
        public const string ScannerPage = "ScannerPage";

        

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<LoginPageViewModel>();
            SimpleIoc.Default.Register<ScannerPageViewModel>();

        }

        public LoginPageViewModel LoginPageViewModel => ServiceLocator.Current.GetInstance<LoginPageViewModel>();
        public ScannerPageViewModel ScannerPageViewModel => ServiceLocator.Current.GetInstance<ScannerPageViewModel>();

    }
}
