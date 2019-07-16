using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace NightOwl.Views
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel()
        {
            LoginCommand = new Command(Login, ()=> !IsBusy);
        }
        string name = string.Empty;
        string password = string.Empty;

        bool isBusy;
        bool isVisible;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
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
                    OnPropertyChanged(nameof(Mytest));
            }
        }
        public string Mytest
        {
            get { return $"You just entered {Name} and it changes whiles typing";}
        }
       
        public string Password
        {
            get { return password; }
            set {
                password = value;
                if (password != string.Empty)
                    IsVisible = true;
                else
                    IsVisible = false;
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

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = true;
                OnPropertyChanged();
            }
        }
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }
        void Login()
        {
            Application.Current.MainPage = new MyTestShell();
        }

        /*void Register()
        {
            Navigation.PushAsync(new RegistrationPage(), true);
        }*/
    }
}
