using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_Bookstore.Models
{
    public class BookstoreDatabase
    {
        public string host { get; set; }
        public string databaseName { get; set; }
        public string password { get; set; }

        //methods
        public bool connect() { return true; }
        public string insert(Object field, string tableName) { return "row inserted into table " + tableName + "successfully"; }
        public void select() { }

        public void delete(int id, string tableName) { }

        public void update(int id, string tableName) { }

    }
}