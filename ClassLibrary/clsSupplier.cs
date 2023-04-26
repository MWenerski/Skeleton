using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data memeber for the ID property
        private int mID;
        public int ID
        {
            get
            {
                //this line of code sends data out the property
                return mID;
            }
            set
            {
                //this line of code allows data into the property
                mID = value;
            }
        }
        private string mSupplierName;
        public string SupplierName
        {
            get
            {
                //this line of code sends data out the property
                return mSupplierName;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierName = value;
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                //this line of code sends data out the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded {
            get
            {
                //this line of code sends data out the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        private string mContactNumber;
        public string ContactNumber
        {
            get
            {
                //this line of code sends data out the property
                return mContactNumber;
            }
            set
            {
                //this line of code allows data into the property
                mContactNumber = value;
            }
        }
        private string mAddress;
        public string Address
        {
            get
            {
                //this line of code sends data out the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }
        private bool mOngoingContract;
        public bool OngoingContract
        {
            get
            {
                //this line of code sends data out the property
                return mOngoingContract;
            }
            set
            {
                //this line of code allows data into the property
                mOngoingContract = value;
            }
        }
        public bool Find(int SupplierID)
        {
            //Create an intance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the supplier id tp search for
            DB.AddParameter("@SupplierID", SupplierID);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Selectall");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mContactNumber= Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mAddress= Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mOngoingContract = Convert.ToBoolean(DB.DataTable.Rows[0]["OngoingContract"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

           /* mID = 2;
            mSupplierName = "name";
            mEmail = "email";
            mDateAdded = Convert.ToDateTime("22/03/2023");
            mContactNumber = "ContactNumber";
            mAddress = "Address";
            mOngoingContract = true;*/
           
        }

        public string Valid(String supplierName, String email, String dateAdded, String contactNumber, String address)
        {
            String Error = "";
            if (supplierName.Length == 0)
            {
                Error = Error + "the supplier name may not be blank : ";
            }
            if (supplierName.Length > 20)
            {
                Error = Error + "the supplier nme must be less than 20 characters : ";
            }

            return Error;
        }
    }
}