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
	public partial class ScannerPage : ContentPage
	{
	    private ScannerPageViewModel _viewModel = App.Locator.ScannerPageViewModel;
		public ScannerPage ()
		{
			InitializeComponent ();
		    BindingContext = _viewModel;
		}
	}
}