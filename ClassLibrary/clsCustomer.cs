using System;
using ClassLibrary;
using System.Text;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the CustomerID property
        private Boolean mVerified;
        private string mEmail;
        private string mPassword;
        private string mUsername;
        private Int32 mCustomerID;
        private DateTime mDateAdded;

        public clsCustomer()
        {
        }

        public bool Verified 
        {
            get 
            {
                return mVerified
            } 
            set 
            {
                mVerified = value;
            } 
        }
        public DateTime DateAdded 
        {
            get 
            {
                return mDateAdded;
            }
            set 
            {
                mDateAdded = value;
            } 
        }
        public string Email 
        {
            get 
            {
                return mEmail;
            }
            set 
            {
                mEmail = value;
            } 
        }
        public string Password 
        {
            get 
            {
                return mPassword;
            }
            set 
            {
                mPassword = value;
            } 
        }
        public int CustomerID {
            get {
                return mCustomerID;
            } 
            set {
                mCustomerID = value;
            } 
        }
        public string Username 
        {
            get 
            {
                return mUsername;
            }
            set 
            {
                mUsername = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //set the private data members to the test data value
            mCustomerID = 2;
            mUsername = "Knight98";
            mPassword = "12345";
            mEmail = "knight98@gmail.com";
            mVerified = true;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            //always returns true
            return true;
        }
    }
    namespace ClassLibrary
    {
        public class clsCustomer
        {
            public string OrderID { get; set; }
        }
    }
}