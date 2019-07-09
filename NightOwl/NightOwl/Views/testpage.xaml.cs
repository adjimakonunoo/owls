using NightOwl.ListFolder;
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
    public partial class testpage : ContentPage
    {
        public testpage()
        {
            InitializeComponent();
            init();
        }
        public async void CameraButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new About_Us());
        }

        public async void TagButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Terms_and_Conditions());
        }

        public async void ShoppingButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AgentPoll());
        }

        public async void TwitterButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AccountsPage());
        }
        void init()
        {
            BackgroundColor = Constants.BackgroundColor2;
            //Lbl_Username.TextColor = Constants.MainTextColor;
            //Lbl_Password.TextColor = Constants.MainTextColor;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new ShowPopup(), true);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as MyItemsView;
            var myItem = e.Item as MyItemsClass;

            vm.HideorShow(myItem);
        }
    }
}