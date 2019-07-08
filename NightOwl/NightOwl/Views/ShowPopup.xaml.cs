using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
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
    public partial class ShowPopup : PopupPage
    {
        public ShowPopup()
        {
            InitializeComponent();
        }

        void Accounts_Btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage (new AccountsPage()), true);
            PopupNavigation.Instance.PopAsync(true);  
        }
    }
}