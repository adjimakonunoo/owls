using NightOwl.Classes;
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
    public partial class Dashboard : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }

        public Dashboard()
        {
            InitializeComponent();
            menuList = new List<MasterPageItem>();

            var page1 = new MasterPageItem() { Title = "About Us", Icon = "aboutus.png", TargetType = typeof(About_Us) };
            var page2 = new MasterPageItem() { Title = "Terms&Conditions", Icon = "TermsAndConditions1.png", TargetType = typeof(Terms_and_Conditions) };
            var page3 = new MasterPageItem() { Title = "Agent Poll", Icon = "yea.png", TargetType = typeof(AgentPoll) };
            var page4 = new MasterPageItem() { Title = "My Account", Icon = "accounts.png", TargetType = typeof(AccountsPage) };


            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);


            DrawerList.ItemsSource = menuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(testpage)));
           IsGestureEnabled = true;
            this.BindingContext = new
            {
                Header = "",
                Image = "",
                Footer = ""
            };
        }
            private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
            var item = (MasterPageItem)e.SelectedItem;
            
            if (item == null)
                return;
            // Type page = item.TargetType;

            //Detail=  (Page)Activator.CreateInstance(page);
            var page = (Page)Activator.CreateInstance(item.TargetType);
            
            Detail = new NavigationPage(page);
            IsPresented = false;
           
            }
        async void LogoutCicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage (new LoginPage()), true);
        }
    }
}