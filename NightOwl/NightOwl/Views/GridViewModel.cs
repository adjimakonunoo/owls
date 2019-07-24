using NightOwl.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace NightOwl.Views
{
    public class GridViewModel : ModelObject
    {

        private ObservableCollection<GridClass> dummyData;

       
        public GridViewModel()
        {
            DummyData = new ObservableCollection<GridClass>();
            GenerateData();
        }

       public ObservableCollection<GridClass> DummyData
        {
            get { return dummyData; }
            set
            {
                dummyData = value;

                OnPropertyChanged();
            }
        }
        public ICommand AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    dummyData.Add(new GridClass("Emmanuel", "Affum", 25, "Games"));
                    dummyData.RemoveAt(1);
                });
            }
        }

        

        private void GenerateData()
        {
            DummyData.Add(new GridClass("Emmanuel", "Frimpong", 25, "Games"));
            DummyData.Add(new GridClass("Emmanuel", "Ntiamoah", 25, "Games"));
            DummyData.Add(new GridClass("Emmanuel", "Mensah", 25, "Games"));
            DummyData.Add(new GridClass("Emmanuel", "Adamba", 25, "Games"));
            DummyData.Add(new GridClass("Emmanuel", "Agyei", 25, "Games"));
            DummyData.Add(new GridClass("Emmanuel", "Ngoah", 25, "Games"));
            DummyData.Add(new GridClass("Emmanuel", "Asante", 25, "Games"));
            DummyData.Add(new GridClass("Emmanuel", "Nyanyo", 25, "Games"));
        }
    }
}
