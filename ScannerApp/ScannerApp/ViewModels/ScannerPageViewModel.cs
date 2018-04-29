using System;
using System.Collections.Generic;
using System.Text;
using Acr.UserDialogs;
using DataObjects;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using ScannerApp.Utils;

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
                    UserDialogs.Instance.ShowLoading();
                    BarcodeBo barcodeBo = await BarcodeDa.ValidateBarcode(result.Text, Settings.StationID, Settings.EmployeeID,
                        Settings.SessionCode);
                    if (barcodeBo?.data != null)
                    {
                        if (barcodeBo.data.scan.result == "validated")
                        {
                            Message = $"Your code is  Validated ";
                        }
                        else
                        {
                            Message = $"Your code is not validated ";
                        }

                    }
                    UserDialogs.Instance.HideLoading();
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
