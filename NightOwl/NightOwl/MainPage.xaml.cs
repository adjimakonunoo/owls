using DevExpress.Mobile.DataGrid;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace NightOwl
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage

    {
        int count;
        public MainPage()
        {
            InitializeComponent();

            TestOrdersRepository model = new TestOrdersRepository();
            BindingContext = model;
        }

        void OnCalculateCustomSummary(object sender, CustomSummaryEventArgs e)
        {
            if (e.FieldName.ToString() == "Shipped")
                if (e.IsTotalSummary)
                {
                    if (e.SummaryProcess == CustomSummaryProcess.Start)
                    {
                        count = 0;
                    }
                    if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                    {
                        if (!(bool)e.FieldValue)
                            count++;
                        e.TotalValue = count;
                    }
                }
        }
    }
}
