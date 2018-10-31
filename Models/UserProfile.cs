using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class UserProfile
    {
        public int ID { get; set; }

        public string UserType { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string gender { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public int PostalCode { get; set; }





        //Methods

        public void viewAvailableBooks() { }

        public void viewBookDetails() { }

        public Book searchBook(string bookName) {
            Book book = new Models.Book();

            return book;

        }

        public bool updateProfile(int userID) { return true; }


    }
}