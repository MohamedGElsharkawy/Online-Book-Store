using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public string paymentMethod { get; set; }

        public double amount { get; set; }
        public string paymentDate { get; set; }

        public Payment selectPaymentMethod() {
            Payment paymentMethod = new Payment();

            return paymentMethod;
        }
    }
}