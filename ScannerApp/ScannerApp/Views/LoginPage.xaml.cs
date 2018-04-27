﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScannerApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScannerApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
	    private LoginPageViewModel _viewModel = App.Locator.LoginPageViewModel;
		public LoginPage ()
		{
			InitializeComponent ();
		    BindingContext = _viewModel;
            NavigationPage.SetHasNavigationBar(this,false);
		}
	}
}