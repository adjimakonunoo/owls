﻿using System;
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
        public List<string> MyList { get; set; }
        public AccountsPage()
        {
            InitializeComponent();

            MyList = new List<string>()
            {
                "hello",
                "hi",
                "hey"
            };

            list.ItemsSource = MyList;
        }

       
    }
}