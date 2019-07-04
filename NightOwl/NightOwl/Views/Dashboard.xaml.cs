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

            var page1 = new MasterPageItem() { Title = "Login", Icon = "bird.png", TargetType = typeof(LoginPage) };
            var page2 = new MasterPageItem() { Title = "Register", Icon = "test.png", TargetType = typeof(RegistrationPage) };
            var page3 = new MasterPageItem() { Title = "Agent Poll", Icon = "yea.png", TargetType = typeof(AgentPoll) };


            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);


            DrawerList.ItemsSource = menuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(testpage)));
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
                Type page = item.TargetType;

                Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            }
        async void LogoutCicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage (new LoginPage()), true);
        }
    }
}