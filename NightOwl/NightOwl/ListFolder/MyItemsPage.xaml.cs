using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NightOwl.ListFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyItemsPage : ContentPage
    {
        public MyItemsPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as MyItemsView;
            var myItem = e.Item as MyItemsClass;

            vm.HideorShow(myItem);

        }

       
    }
}