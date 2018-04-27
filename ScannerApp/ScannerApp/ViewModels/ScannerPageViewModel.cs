using System;
using System.Collections.Generic;
using System.Text;
using Acr.UserDialogs;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace ScannerApp.ViewModels
{
    public class ScannerPageViewModel : BaseViewModel
    {
        public ScannerPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        private string _message="Welcome to Scanner App";

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand ScanCommand => new RelayCommand(Scan);

        private async void Scan()
        {
            try
            {

                var scanner = new ZXing.Mobile.MobileBarcodeScanner();

                var result = await scanner.Scan();

                if (result != null)
                {
                    scanner.Cancel();
                    Message = $"Your code is  {result.Text}";
                    // UserDialogs.Instance.Alert($" {result.Text}");
                    //   Console.WriteLine("Scanned Barcode: " + result.Text);

                }
            }
         
            catch (Exception e)
            {
               
            }
        }
    }
}
