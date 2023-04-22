using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set { }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
            
            
            
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@customerID", mThisOrder.CustomerID);
            DB.AddParameter("@orderID", mThisOrder.OrderID);
            DB.AddParameter("@orderDate", mThisOrder.OrderDate);
            DB.AddParameter("@totalPaid", mThisOrder.TotalPayable);
            DB.AddParameter("@gameName", mThisOrder.GameName);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@customerID", mThisOrder.CustomerID);
            DB.AddParameter("@orderID", mThisOrder.OrderID);
            DB.AddParameter("@orderDate", mThisOrder.OrderDate);
            DB.AddParameter("@totalPaid", mThisOrder.TotalPayable);
            DB.AddParameter("@gameName", mThisOrder.GameName);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByGameName(string GameName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@gameName", GameName);
            DB.Execute("sproc_tblOrder_FilterByGameName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["customerID"]);
                AnOrder.GameName = Convert.ToString(DB.DataTable.Rows[Index]["gameName"]); 
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["orderDate"]); 
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["orderID"]);
                AnOrder.TotalPayable = Convert.ToDouble(DB.DataTable.Rows[Index]["totalPaid"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
    }
}