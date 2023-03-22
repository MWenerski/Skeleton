using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        private Boolean mActive;

        public Boolean Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        private string mOrderID;
        public string OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string GameName { get; set; }
        public bool InStock { get; set; }
        public DateTime OrderDate { get; set; }
        public double GamePrice { get; set; }
        public double TotalPayable { get; set; }
        public int CustomerID { get; set; }

        private Int32 mOrderNo;

        public Int32 OrderNo
        {
            get
            {
               return mOrderNo;
            }
            set
            {
               mOrderNo = value;
            }
        }

        public bool Find(int OrderNo)
        {
            mOrderNo = 21;
            return true;
        }
    }
}