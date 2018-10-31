using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class Admin:UserProfile
    {


        //Methods

        public bool addCatalog(Catalog catalog) { return true; }


        public  bool manageCatalog(int catalogID) { return true; }//edit and delete catalog 

        public bool addBookIntoStore(Book book , Store store) { return true; }

        public bool manageBookInfo(int bookID) { return true; }//edit and delete book 
        public bool addCustomer(Customer customer) { return true; }

        public bool deleteCustomer(int customerID) { return true; }

        public Customer searchForCustomer(int customerID) {
            Customer customer = new Customer();
            return customer; }

        public bool sendNotification(Notification notification,int customerID) { return true; }

        public bool confirmCustomerOrder(int orderId) { return true; }

        public void recieveFeedback() { }


    }
}