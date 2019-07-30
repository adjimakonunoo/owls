using System;
using System.Collections.Generic;
using System.Text;
using ZXing.Net.Mobile.Forms;
using ZXing.Common;
using Xamarin.Forms;
using ZXing;

namespace NightOwl.Views
{
   public class AboutUsViewModel : ModelObject
    {
        public AboutUsViewModel()
        {
            ScannerCommand = new Command(Scanner);
            //GenerateCommand = new Command(Generate);
        }
        string entrytext;
        public Command ScannerCommand { get; }

        public string EntryText
        {
            get { return entrytext; }
            set
            {
                entrytext = value;
                OnPropertyChanged();
            }
        }
      async void Scanner()
        {
            var ScannerPage = new ZXingScannerPage();

            ScannerPage.OnScanResult += (result) => {
                // Stop scanning
                ScannerPage.IsScanning = false;

                // Alert with scanned code
                Device.BeginInvokeOnMainThread(() => {
                    Application.Current.MainPage.Navigation.PopAsync();
                    EntryText = result.Text;
                });
            };


            await Application.Current.MainPage.Navigation.PushAsync(ScannerPage);
        }
        //public Command GenerateCommand { get; }
        //void Generate()
        //{
        //    var barcode = new ZXingBarcodeImageView();
        //    {
        //        barcode.BarcodeValue = EntryText;
        //        barcode.BarcodeFormat = BarcodeFormat.QR_CODE;
        //        barcode.IsVisible = true;
        //        barcode.BarcodeOptions.Height = 300;
        //        barcode.BarcodeOptions.Width = 300;
                  
        //    barcode.VerticalOptions = LayoutOptions.CenterAndExpand;
        //        barcode.HorizontalOptions = LayoutOptions.CenterAndExpand;
        //            };
        //    About_Us hi = new About_Us();
        //    hi.Content = barcode;
        //}
    }
    //ZXingBarcodeImageView GenerateQR(string EntryText)
    //{
    //    var qrCode = new ZXingBarcodeImageView
    //    {
    //        BarcodeFormat = BarcodeFormat.QR_CODE,
    //        BarcodeOptions = new QrCodeEncodingOptions
    //        {
    //            Height = 350,
    //            Width = 350
    //        },
    //        BarcodeValue = EntryText,
    //        VerticalOptions = LayoutOptions.CenterAndExpand,
    //        HorizontalOptions = LayoutOptions.CenterAndExpand
    //    };

    //    return qrCode;
    //}

}
