using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class Invoice
    {
        public int invoiceNumber { get; set; }
        public string invoiceDate { get; set; }

        public int customerId { get; set; }
        public Order order { get; set; }

        public Payment paymentMethod { get; set; }

        public void insertInvoice() { }

        public bool updateInvoice(int invoiceNumber) { return true; }

        public bool deleteInvoice(int invoiceNumber) { return true; }

    }
}