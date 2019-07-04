using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NightOwl
{
    public class NetworkCheck
    {
        public static bool Internet()
        {
            if(CrossConnectivity.Current.IsConnected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
