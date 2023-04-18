﻿using System;

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

        private Int32 mOrderID;
        public Int32 OrderID
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

        public string Valid(string dateAdded, string quantity, string gamePrice, string orderPrice, string totalPayable, string gameName, string orderID, string customerID)
        {
            String Error = "";
            if(gameName.Length == 0)
            {
                Error = Error + "The game name cannot be blank. ";
            } 
            if (gameName.Length > 50)
            {
                Error = Error + "The game length is too long. ";
            }
            DateTime DateTemp;
            try
            {

                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Today.Date)
                {
                    Error = Error + "The date cannot be in the past. ";
                }
                if (DateTemp > DateTime.Today.Date)
                {
                    Error = Error + "The date cannot be in the future. ";
                }
            }
            catch
            {
                Error = Error + "The date was invalid. ";
            }
            
                if (quantity.Length != 0)
                {
                    if(Convert.ToInt32(quantity) < 1 || Convert.ToInt32(quantity) > 9)
                    Error += "The quantity must be between 1 and 9 inclusive. ";
                }
           else
            {
                Error += " The quantity was invalid.";
            }
            try
            {
                if (customerID.Length > 8 || customerID.Length < 8)
                {
                    Error += "Customer ID is not 8 digits.";
                }
            }catch
            {
                Error += " The customer ID is invalid.";
            }
            if (orderID.Length != 0)
            {
                if (Convert.ToInt32(orderID) < 1 || Convert.ToInt32(orderID) > 999999999)
                {
                    Error += "Order ID is the wrong length.";
                }
            }
            else
            {
                Error += " OrderId invalid.";
            }
            try
            {
                Double PayableTemp = Convert.ToDouble(totalPayable);
                if (PayableTemp == 0 || PayableTemp > 10000)
                {
                    Error += "The total payable doesn't seem right.";
                }
            } catch
            {
                Error += "The total payable doesn't seem right.";
            }
            
           
                if (orderPrice.Length == 0 || orderPrice.Length > 6)
                {
                    Error += "It seems like there is a discrepancy in the orderPrice.";
                }                
            else
            {
               
            }
           
                if (gamePrice.Length == 0 || gamePrice.Length > 5)
                {
                    Error += "The game price doesn't seem right.";
                }
            else 
            {
                
            }
            return Error;
        }

        public bool CheckDataBase()
        {
            clsDataConnection DB = new clsDataConnection();
            return DB.checkConnectionDB();
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
        private Int32 mOrderlineId;
        public Int32 OrderlineId {
            get
            {
                return mOrderlineId;
            }
            set
            {
                mOrderlineId = value;
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
        private Double mOrderPrice;
        public Double OrderPrice
        {
            get
            {
               return mOrderPrice;
            }
            set
            {
               mOrderPrice = value;
            }
        }

        public bool Find(int orderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderID", orderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            
            if(DB.Count == 1)
            {
               mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
               mGameName = Convert.ToString(DB.DataTable.Rows[0]["game"]);
                mGamePrice = Convert.ToDouble(DB.DataTable.Rows[0]["gamePrice"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["inStock"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["orderDate"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["orderID"]);
                mOrderPrice = Convert.ToDouble(DB.DataTable.Rows[0]["orderPrice"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["quantity"]);
                mTotalPayable = Convert.ToDouble(DB.DataTable.Rows[0]["totalPaid"]);
                mOrderlineId = Convert.ToInt32(DB.DataTable.Rows[0]["orderlineId"]);
                
                return true;
            } else
            {
                return false;
            }
        }
    }
}