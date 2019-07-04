﻿using NightOwl.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
            init();


            this.BindingContext = this;
            this.IsBusy = false;
            Btn_SignIn.Clicked += SignInProcedure;
        }
        void init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;

           
            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
            
        }
         void SignInProcedure(object sender, EventArgs e)
        {
             this.IsBusy = true;
            
            User user = new User(Entry_Username.Text, Entry_Password.Text);

           // if (user.CheckInformation())
            //{
                
                Navigation.PushModalAsync(new Dashboard(), true);
                
           /* }
            else
            {
                DisplayAlert("Login", "Username or Password incorrect", "Ok");
                this.IsBusy = false;
            }*/
        }
        async void RegisterProcedure(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new RegistrationPage()), true);
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            Entry_Username.Text = "";
            Entry_Password.Text = "";
        }
    }
}