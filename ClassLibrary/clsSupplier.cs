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
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public DateTime DateAdded { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public bool OngoingContract { get; set; }

        public bool Find(int iD)
        {
            mID = 2;
            return true;
        }
    }
}