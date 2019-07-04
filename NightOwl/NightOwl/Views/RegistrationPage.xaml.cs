using NightOwl.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NightOwl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_First_Name.TextColor = Constants.MainTextColor;
            Lbl_Last_Name.TextColor = Constants.MainTextColor;
            Lbl_Email.TextColor = Constants.MainTextColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            Lbl_Confirm_Password.TextColor = Constants.MainTextColor;
            


            Entry_First_Name.Completed += (s, e) => Entry_Last_Name.Focus();
            Entry_Last_Name.Completed += (s, e) => Entry_Email.Focus();
            Entry_Email.Completed += (s, e) => Entry_Username.Focus();
            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => Entry_Confirm_Password.Focus();
             Entry_Confirm_Password.Completed +=(s, e) => RegisterProcedure(s, e);
        }
        void RegisterProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckRegInfo())
            {
                DisplayAlert("Registration", "Successful", "Ok");
                Navigation.PushModalAsync(new Dashboard(), true);
            }
            else
            {
                DisplayAlert("Registration", "Please fill all entries", "Ok");
            }
        }
        async void SignInProcedure(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new LoginPage()), true);
        }

        private void LogoutClicked(object sender, EventArgs e)
        {

        }

        private void Clear_Clicked(object sender, EventArgs e)
        {

        }
    }
}