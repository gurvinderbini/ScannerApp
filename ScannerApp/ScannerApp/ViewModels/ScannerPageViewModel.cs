﻿using System;
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
#if __ANDROID__
// Initialize the scanner first so it can track the current context
	MobileBarcodeScanner.Initialize (Application);
#endif

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
