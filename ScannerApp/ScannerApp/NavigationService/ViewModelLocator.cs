using System;
using System.Collections.Generic;
using System.Text;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using ScannerApp.ViewModels;

namespace ScannerApp.NavigationService
{
   public class ViewModelLocator
    {
        public const string LoginPage = "LoginPage";

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<LoginPageViewModel>();
        }

        public LoginPageViewModel LoginPageViewModel => ServiceLocator.Current.GetInstance<LoginPageViewModel>();
         }
}
