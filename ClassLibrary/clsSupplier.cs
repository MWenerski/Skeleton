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
        public bool Find(int iD)
        {
            mID = 2;
            return true;
        }
    }
}