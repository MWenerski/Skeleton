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
                return mVerified;
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

        //
        public string OrderID { get; set; }

        // Added 22/03/2023

        public bool CheckDataBase()
        {
            clsDataConnection DB = new clsDataConnection();
            return DB.checkConnectionDB();
        }

        public bool Find(int CustomerID)
        {
            //connection string
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_SelectAll");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mVerified = Convert.ToBoolean(DB.DataTable.Rows[0]["Verified"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateCreated"]);
                return true;
            }
            else 
            {
                return false;
            }

            /*set the private data members to the test data value
            mCustomerID = 2;
            mUsername = "Knight98";
            mPassword = "12345";
            mEmail = "knight98@gmail.com";
            mVerified = true;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            //always returns true
            return true;
            */
        }

        public string Valid(string username, string password, string email, string dateAdded)
        {
            String error = "";
            DateTime DateTemp;

            if (username.Length == 0) 
            {
                error = error + "The username may not be blank : ";
            }
            if (username.Length > 10) 
            {
                error = error + "The username must be less than 10 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Today.Date)
                {
                    error = error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Today.Date)
                {
                    error = error + "The date cannot be in the future : ";
                }
            }
            catch 
            {
                error = error + "The date was not a valid date : ";
            }
            if (password.Length == 0)
            {
                error = error + "The username may not be blank : ";
            }
            if (password.Length > 10)
            {
                error = error + "The username must be less than 10 characters : ";
            }
            if (username.Length == 0)
            {
                error = error + "The username may not be blank : ";
            }
            if (username.Length > 20)
            {
                error = error + "The username must be less than 20 characters : ";
            }

            return error;
        }
    }
}
