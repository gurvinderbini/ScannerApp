using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsPinView.PCL;
using GalaSoft.MvvmLight;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using ScannerApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScannerApp.Popups
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PinPopup : PopupPage
    {
		public PinPopup (ScannerPageViewModel scannerPageViewModel)
		{
			InitializeComponent ();
		    var viewModel = new PinAuthViewModel();
		    viewModel.PinViewModel.Success += (object sender, EventArgs e) =>
		    {
		        scannerPageViewModel.LayoutVisibility = true;
		        PopupNavigation.PopAsync();
		    };
		    base.BindingContext = viewModel;
        }

        public class PinAuthViewModel : ViewModelBase
        {
            private readonly char[] _correctPin;
            private readonly PinViewModel _pinViewModel;

            public PinViewModel PinViewModel => _pinViewModel;

            public PinAuthViewModel()
            {

                _correctPin = new[] { '1', '2', '3', '4' };
                _pinViewModel = new PinViewModel
                {
                    TargetPinLength = 4,
                    ValidatorFunc = (arg) => Enumerable.SequenceEqual(arg, _correctPin)
                };
                _pinViewModel.Success += (object sender, EventArgs e) =>
                {
                    Debug.WriteLine("Success. Assume page will be closed automatically.");
                };
            }
        }
    }
}