using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace NightOwl.ListFolder
{
    public class MyItemsView
    {
        private MyItemsClass _oldMyItemsClass;
        public ObservableCollection<MyItemsClass> MyItems { get; set; }
        
        
        
        

        public MyItemsView()
        {
            MyItems = new ObservableCollection<MyItemsClass>
            {
                new MyItemsClass
                {
                    Title = "Hello",
                    IsVisible = false
                },
               
            
            
                new MyItemsClass
                {
                    Title = "Welcome",
                   
                }
            };
        }
        

        public void HideorShow(MyItemsClass myItem)
        {
           if (_oldMyItemsClass ==myItem)
            {
                //click twice on the same item will hide it
                myItem.IsVisible = !myItem.IsVisible;
                UpdateMyItems(myItem);
            }
            else
            {
                if (_oldMyItemsClass != null)
                {
                    //hide previous selected item
                    _oldMyItemsClass.IsVisible = false;
                    UpdateMyItems(_oldMyItemsClass);
                }
                //show selected item
                myItem.IsVisible = true;
                UpdateMyItems(myItem);
            }

            _oldMyItemsClass = myItem;
        }

        private void UpdateMyItems(MyItemsClass myItem)
        {
                var index = MyItems.IndexOf(myItem);
                MyItems.Remove(myItem);
                MyItems.Insert(index, myItem);
            
        }
       

        
    }
}
