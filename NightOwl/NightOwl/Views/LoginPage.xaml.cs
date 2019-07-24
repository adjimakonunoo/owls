
using NightOwl.Views;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NightOwl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
           

            BindingContext = new LoginViewModel();
            
            BackgroundColor = Constants.BackgroundColor;
        }
        
    }
}