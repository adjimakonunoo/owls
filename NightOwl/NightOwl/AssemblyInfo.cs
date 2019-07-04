using Android.App;
using Android.Graphics.Drawables;
using Xamarin.Forms.Xaml;



[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

#if DEBUG
[assembly: Application(Debuggable=true)]
#else
[assembly: Application(Debuggable = false)]
#endif