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
    public partial class MyTestShell : Shell
    {
        public MyTestShell()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}