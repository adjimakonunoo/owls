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
        public class test
        {
            public string title { get; set; }
            public string pic { get; set; }

            internal void changetitle(test Mest)
            {
                Mest.title = "Come" ;
            }
        }
        public test Mest { get;set; }
        public List<MasterPageItem> MenuList { get; set; }

       
        public Dashboard()
        {
           
            InitializeComponent();

            //lbl.BindingContext = DrawerList;
            //lbl.SetBinding(lbl.Text,);

            MenuList = new List<MasterPageItem>();
          Mest = new test();
            var page1 = new MasterPageItem() { Title = "About Us", Icon = "aboutus.png", TargetType = typeof(About_Us) };
            var page2 = new MasterPageItem() { Title = "Terms&Conditions", Icon = "TermsAndConditions1.png", TargetType = typeof(Terms_and_Conditions) };
            var page3 = new MasterPageItem() { Title = "Agent Poll", Icon = "yea.png", TargetType = typeof(AgentPoll) };
            var page4 = new MasterPageItem() { Title = "My Account", Icon = "accounts.png", TargetType = typeof(AccountsPage) };
            
            
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);


            DrawerList.ItemsSource = MenuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(testpage)));
           IsGestureEnabled = true;
            this.BindingContext = new
            {
                Header = "",
                Image = "",
                Footer = ""
            };
            
        }
        
        
       void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
            var item = (MasterPageItem)e.SelectedItem;
            
            if (item == null)
                return;
            
            var page = (Page)Activator.CreateInstance(item.TargetType);
            var ch =Mest;
            Detail = new NavigationPage(page);
            if (item == MenuList[1])
                ch.changetitle(Mest);
            IsPresented = false;
            System.Diagnostics.Debug.WriteLine(Mest.title);
            }
        
        async void LogoutCicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage (new LoginPage()), true);
        }

    }
}