using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using ScannerApp.Popups;
using ScannerApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScannerApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScannerPage : ContentPage
	{
	    private readonly ScannerPageViewModel _viewModel = App.Locator.ScannerPageViewModel;
		public ScannerPage ()
		{
			InitializeComponent ();
		    BindingContext = _viewModel;
		    _viewModel.LayoutVisibility = false;
		    PopupNavigation.PushAsync(new PinPopup(_viewModel));

		}


	}
}