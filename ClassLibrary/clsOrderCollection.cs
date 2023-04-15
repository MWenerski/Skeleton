﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList { get
            {
                return mOrderList;
            }
            set {
                mOrderList = value;
            } }
        public int Count { get
            {
                return mOrderList.Count;
            }
            set { } }

        public clsOrder ThisOrder { get; set; }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["active"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["customerID"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateAdded"]);
                AnOrder.GameName = Convert.ToString(DB.DataTable.Rows[Index]["gameName"]);
                AnOrder.GamePrice = Convert.ToDouble(DB.DataTable.Rows[Index]["gamePrice"]);
                AnOrder.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["inStock"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["orderDate"]); ;
                AnOrder.OrderID = Convert.ToString(DB.DataTable.Rows[Index]["orderID"]);
                AnOrder.OrderPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["orderPrice"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["quantity"]);
                AnOrder.TotalPayable = Convert.ToDouble(DB.DataTable.Rows[Index]["totalPaid"]);
                AnOrder.TotalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["totalPrice"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
    }
}