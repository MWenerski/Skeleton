using System;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Verified { get; set; }
        public DateTime DateAdded { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CustomerID { get; set; }
        public string Username { get; set; }
    }
    namespace ClassLibrary
    {
        public class clsCustomer
        {
            public string OrderID { get; set; }
        }
    }
}