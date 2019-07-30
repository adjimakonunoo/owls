using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace NightOwl.Droid
{
    [Activity( Icon = "@drawable/bird", NoHistory =true, Theme = "@style/SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();
            //System.Threading.Thread.Sleep(500);
            //StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            // Create your application here
        }

        //protected override void OnResume()
        //{
        //    base.OnResume();
        //    Task startupwork = new Task(() => { SimulateStartup(); });
        //    startupwork.Start();
            
        //}

        //async void SimulateStartup()
        //{
        //   await Task.Delay(500);
        //    StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        //    Finish();
        //}
    }
}