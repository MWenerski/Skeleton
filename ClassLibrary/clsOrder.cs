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

        public bool Find(int orderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderID", orderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID")
            if(DB.Count == 1)
            {
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mGameName = Convert.ToString(DB.DataTable.Rows[0]["GameName"]);
                mGamePrice = Convert.ToDouble(DB.DataTable.Rows[0]["GamePrice"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]); ;
                mOrderID = Convert.ToString(DB.DataTable.Rows[0]["OrderID"]);
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mTotalPayable = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPayable"]);
                mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPrice"]);
                return true;
            } else
            {
                return false;
            }
        }
    }
}