using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using ScannerApp.NavigationService;
using ScannerApp.Views;
using Xamarin.Forms;

namespace ScannerApp
{
	public partial class App : Application
	{
	    #region Locator
	    private static ViewModelLocator _locator;
	    public static ViewModelLocator Locator => _locator ?? (_locator = new ViewModelLocator());
	    #endregion
        public App ()
		{
			InitializeComponent();
		    var navigationService = new NavigationService.NavigationService();
		    navigationService.Configure(ViewModelLocator.LoginPage, typeof(LoginPage));
		    navigationService.Configure(ViewModelLocator.ScannerPage, typeof(ScannerPage));


            if (!SimpleIoc.Default.IsRegistered<INavigationService>())
		        SimpleIoc.Default.Register<INavigationService>(() => navigationService);

		    var firstPage = new NavigationPage(new LoginPage());
		    navigationService.Initialize(firstPage);
		    MainPage = firstPage;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
