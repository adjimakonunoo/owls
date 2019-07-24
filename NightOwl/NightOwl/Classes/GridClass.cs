using System;
using System.Collections.Generic;
using System.Text;

namespace NightOwl.Classes
{
    public class GridClass : ModelObject
    {
        string FirstName;
        string LastName;
        int Age;
        string Favourite;

        public GridClass(string FirstName, string LastName, int Age, string Favourite)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Favourite = Favourite;
        }

        public string FIRSTNAME
        {
            get { return FirstName; }
            set
            {
                if(FirstName != value)
                {
                    FirstName = value;
                    OnPropertyChanged();
                }
            }
        }

        public string LASTNAME
        {
            get { return LastName; }
            set
            {
                if(LastName != value)
                {
                    LastName = value;
                    OnPropertyChanged();
                }
            }
        }
        public int AGE
        {
            get { return Age; }
            set
            {
                if(Age != value)
                {
                    Age = value;
                    OnPropertyChanged();
                }
            }
        }
        public string FAVOURITE
        {
            get { return Favourite; }
            set
            {
                if(Favourite != value)
                {
                    Favourite = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
