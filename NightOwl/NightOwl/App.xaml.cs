using NightOwl.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MonkeyCache.FileStore;


namespace NightOwl
{
    public partial class App : Application
    {
        public static RestService ApiServices = new RestService();
        public App()
        {
            InitializeComponent();
            try
            {


                Barrel.ApplicationId = "NightOwl" + DateTime.Now;
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }

            //AppCenter.Start("2dd16cff-9b51-4f8c-a664-365eddc7d6ac", typeof(Push));
            MainPage = new NavigationPage (new LoginPage());
           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
