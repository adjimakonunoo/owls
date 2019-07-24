using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace NightOwl
{
    public class ModelObject : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

       protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
