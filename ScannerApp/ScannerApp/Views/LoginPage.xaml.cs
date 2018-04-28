using System;
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

	    private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
	    {
	        Entry entry = sender as Entry;
	        String val = entry.Text; //Get Current Text

	        if (val.Length > 4)//If it is more than your character restriction
	        {
	            val = val.Remove(val.Length - 1);// Remove Last character 
	            entry.Text = val; //Set the Old value
	        }
	    }
	}
}