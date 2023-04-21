using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //fields
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        //constructor
        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.Verified = Convert.ToBoolean(DB.DataTable.Rows[Index]["Verified"]);
                AnCustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["Customer"]);
                AnCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                mCustomerList.Add(AnCustomer);
                Index++;
            }
        }
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }

        }
        public clsCustomer ThisCustomer {
            get 
            {
                return mThisCustomer;
            }
            set 
            {
                mThisCustomer = value;
            }
        }


        public int Add()
        {
            //throw new NotImplementedException();
            //mThisCustomer.CustomerID = 123;
            //return mThisCustomer.CustomerID;
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Verified", mThisCustomer.Verified);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            return DB.Execute("sproc_tblCustomer_Insert");
        }
    }
}