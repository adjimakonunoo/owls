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
    public partial class AccountsPage : ContentPage
    {
       
        public AccountsPage()
        {
            InitializeComponent();
            
            BindingContext = new GridViewModel();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as GridViewModel;
            DummyList.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                DummyList.ItemsSource = _container.DummyData;
            else
                DummyList.ItemsSource = _container.DummyData.Where(i => i.LASTNAME.ToLower().Contains(e.NewTextValue.ToLower()));
            DummyList.EndRefresh();
        }
    }
}