using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NightOwl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgentPoll : ContentPage
    {
        public AgentPoll()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            PhoneDialer.Open(phonecall.Text);
        }

        private async void Email_Clicked(object sender, EventArgs e)
        {
            var message = new EmailMessage(agentemmanuel.Text, "", emailer.Text);
            await Email.ComposeAsync(message);
        }

        private void AddFrame_Clicked(object sender, EventArgs e)
        {
            var frame = new Frame
            {
                Content = new Label { Text = "hi" },
                BorderColor = Color.DodgerBlue,
                HorizontalOptions = LayoutOptions.Center
            };
            MasterStack.Children.Add(frame);
        }
    }
}