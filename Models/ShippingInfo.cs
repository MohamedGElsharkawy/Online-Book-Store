using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class ShippingInfo
    {
        public int shippingID { get; set; }

        public string dateShipped { get; set; }

        public string shippingType { get; set; }

        public float shippingCost { get; set;}

        public string shippingRegion { get; set; }


        //methods

        public void updateShippingInfo(int shippingID) { }
    }
}