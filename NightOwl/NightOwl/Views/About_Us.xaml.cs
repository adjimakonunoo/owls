using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
        void init()
        {
            BackgroundColor = Constants.BackgroundColor;
        }
    }
}