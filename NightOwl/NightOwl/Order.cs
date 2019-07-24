using System;
using System.Collections.Generic;
using System.Text;

namespace NightOwl
{
    public class Order : ModelObject
    {

        DateTime date;
        bool shipped;
        Product product;
        int quantity;

        public Order()
        {
            this.date = DateTime.Today;
            this.shipped = false;
            this.product = new Product("", 0);
            this.quantity = 0;
        }

        public Order(DateTime date, bool shipped, Product product, int quantity)
        {
            this.date = date;
            this.shipped = shipped;
            this.product = product;
            this.quantity = quantity;
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool Shipped
        {
            get { return shipped; }
            set
            {
                if (shipped != value)
                {
                    shipped = value;
                    OnPropertyChanged();
                }
            }
        }

        public Product Product
        {
            get { return product; }
            set
            {
                if (product != value)
                {
                    product = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
