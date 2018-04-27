using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace ScannerApp.ViewModels
{
    public class ScannerPageViewModel : BaseViewModel
    {
        public ScannerPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public RelayCommand ScanCommand => new RelayCommand(Scan);

        private async void Scan()
        {
            try
            {

                var scanner = new ZXing.Mobile.MobileBarcodeScanner();

                var result = await scanner.Scan();

                if (result != null)
                    Console.WriteLine("Scanned Barcode: " + result.Text);
            }
         
            catch (Exception e)
            {
               
            }
        }
    }
}
