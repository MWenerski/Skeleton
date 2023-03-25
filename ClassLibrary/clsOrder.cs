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
        public DateTime DateAdded {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        private int mQuantity;
        public int Quantity {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        private double mTotalPrice;
        public double TotalPrice {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }
        private string mGameName;
        public string GameName {
            get
            {
                return mGameName;
            }
            set
            {
                mGameName = value;
            }
        }
        private bool mInStock;
        public bool InStock {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }
        }
        private DateTime mOrderDate;
        public DateTime OrderDate {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        private double mGamePrice;
        public double GamePrice {
            get
            {
                return mGamePrice;
            }
            set
            {
                mGamePrice = value;
            }
        }
        private double mTotalPayable;
        public double TotalPayable {
            get
            {
                return mTotalPayable;
            }
            set
            {
                mTotalPayable = value;
            }
        }
        private int mCustomerID;
        public int CustomerID {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
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
            mActive = true;
            mDateAdded = Convert.ToDateTime("16/09/2015");
            mOrderDate = Convert.ToDateTime("16/09/2015");
            mQuantity = 4;
            mGamePrice = 49.98;
            mTotalPrice = 49.99;
            mTotalPayable = 49.98;
            mGameName = "sussy";
            mOrderID = "343988";
            mCustomerID = 4998;
            mOrderNo = 21;
            mInStock = true;
            return true;
        }
    }
}