using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net.Mobile.Forms;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NightOwl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class About_Us : ContentPage
    {
        public About_Us()
        {
            InitializeComponent();
            init();
            BindingContext = new AboutUsViewModel();
        }
        void init()
        {
            BackgroundColor = Constants.BackgroundColor;
        }

        private void Generate_Barcode(object sender, EventArgs e)
        {
            BarcodeImageView.BarcodeValue = codeent.Text;
            BarcodeImageView.IsVisible = true;
        }
    }
}