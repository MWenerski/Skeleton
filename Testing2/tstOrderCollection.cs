﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstOrderCollection
    {
        public object AllOrders { get; private set; }

       
        //----------------------------------------------------------------------------------------------------------    
        //Creating the collection class
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        //CustomerList property
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 5829834;
            TestItem.GameName = "john";
            TestItem.GamePrice = 24.99;
            TestItem.CustomerID = 9823;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.InStock = true;
            TestItem.OrderPrice = 24.99;
            TestItem.Quantity = 4;
            TestItem.TotalPayable = 24.99;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

       

        //This customer property OK
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderID = 8481934;
            TestOrder.GameName = "john";
            TestOrder.GamePrice = 24.99;
            TestOrder.CustomerID = 9823;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.InStock = true;
            TestOrder.OrderPrice = 24.99;
            TestOrder.Quantity = 4;
            TestOrder.TotalPayable = 24.99;

            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        //tests if records can be added to the lists and count property correctly
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderID = 385823;
            TestOrder.GameName = "john";
            TestOrder.GamePrice = 24.99;
            TestOrder.CustomerID = 9823;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.InStock = true;
            TestOrder.OrderPrice = 24.99;
            TestOrder.Quantity = 4;
            TestOrder.TotalPayable = 24.99;
            TestList.Add(TestOrder);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        
    }


}