using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace NightOwl.Views
{
    public class AgentPollViewModel : ModelObject
    {
        public AgentPollViewModel()
        {
            AddFrameCommand = new Command(AddFrame);
            MessageCommand = new Command(Message);
            EmailCommand = new Command(Emailer);
            CallCommand = new Command(Call);
        }
        public Command AddFrameCommand { get; }
        string messagetext;
        string emmanuelEmail = "ntiamoahemmanuel244@gmail.com";
        string emmanuelEmailHeader = "Hello Agent Emmanuel";
        string number = "0545331451";
        async void Emailer()
        {
            try
            {
                await Email.ComposeAsync(new EmailMessage(EmmanuelEmailHeader," ", EmmanuelEmail));
            }
            catch (Exception)
            {

            }
        }
        
        void Call()
        {
            PhoneDialer.Open(Number);
        }
        public string EmmanuelEmailHeader
        {
            get { return emmanuelEmailHeader; }
            set
            {
                emmanuelEmailHeader = value;
                OnPropertyChanged();
            }
        }
        public string EmmanuelEmail
        {
            get { return emmanuelEmail; }
            set
            {
                emmanuelEmail = value;
                OnPropertyChanged();
            }
        }
        public string Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged();
            }
        }
        void AddFrame()
        {
           
                     new Frame
                    {
                        Content = new Label { Text = "hi" },
                        BorderColor = Color.DodgerBlue,
                        HorizontalOptions = LayoutOptions.Center
                    };
                    
                    //MasterStack.Children.Add(frame);
                
            
        }
        public Command MessageCommand { get; }
        public Command EmailCommand { get; }
        public Command CallCommand { get; }

        async void Message()
        {
            try
            {
                await Sms.ComposeAsync(new SmsMessage(MessageText, "0545331451"));
            }
            catch (Exception)
            {

            }
        }
        public string MessageText
        {
            get { return messagetext; }
            set
            {
                messagetext = value;
                OnPropertyChanged();
            }
        }
    }
}
