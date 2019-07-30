using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace NightOwl.Views
{
    public class LoginViewModel : ModelObject
    {
        public LoginViewModel()
        {
            LoginCommand = new Command(Login, ()=> !IsBusy);
            RegisterCommand = new Command(Register, ()=> !IsBusy);
        }
        string name = string.Empty;
        string password = string.Empty;
        

        bool isBusy;
        bool isVisible;
        bool isShowing;
        public string Name
        {
            get { return name; }
            set {
                    name = value;
                if (name != string.Empty)
                    IsVisible = true;
                else
                    IsVisible = false;
                    OnPropertyChanged();
                OnPropertyChanged(nameof(Lab));
                    //OnPropertyChanged(nameof(Mytest));
            }
        }
         public string Lab
        {
            get { return $" {Name} "; }
           
            
        }
        //public string Mytest
        //{
        //    get { return $"You just entered {Name} and it changes whiles typing";}
        //}
       
        public string Password
        {
            get { return password; }
            set {
                password = value;
                if (password != string.Empty)
                    IsShowing = true;
                else
                    IsShowing = false;
                OnPropertyChanged();

            }
        }

        public bool IsVisible
        {
            get { return isVisible; }
            set {
                isVisible = value;
                
                OnPropertyChanged();
            }
        }
        public bool IsShowing
        {
            get { return isShowing; }
            set
            {
                isShowing = value;
                OnPropertyChanged();
            }
        }
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = true;
                OnPropertyChanged();
                LoginCommand.ChangeCanExecute();
                RegisterCommand.ChangeCanExecute();
            }
        }
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }
        void Login()
        {
            /* User user = new User(Entry_Username.Text, Entry_Password.Text); 

               if (user.CheckInformation())
            { */
            Application.Current.MainPage = new MyTestShell();

        /*}
        else
        {
         DisplayAlert("Login", "Username or Password incorrect", "Ok");*/
    }
      // public INavigation Navigation { get; set; }
         void Register()
        {
            try
            {
                Application.Current.MainPage.Navigation.PushAsync(new RegistrationPage());
                
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
    }
}
