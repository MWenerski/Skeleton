using ClassLibrary;
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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Random rnd = new Random();
            Int32 PrimaryKey = rnd.Next();
            //set its properties
            TestItem.CustomerID = 28478192;
            TestItem.GameName = "test";
            TestItem.OrderDate = DateTime.Today.Date;
            TestItem.GamePrice = 24.44;
            TestItem.InStock = true;
            TestItem.OrderID = PrimaryKey;
            TestItem.OrderlineId = rnd.Next();
            TestItem.OrderPrice = 69.42;
            TestItem.Quantity = 3;
            TestItem.TotalPayable = 34.4;
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem; //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert. AreEqual(AllOrders. ThisOrder, TestItem);
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Random rnd = new Random();
            Int32 PrimaryKey = rnd.Next();
            //set its properties
            TestItem.CustomerID = 28478192;
            TestItem.GameName = "test";
            TestItem.OrderDate = DateTime.Today.Date;
            TestItem.GamePrice = 24.44;
            TestItem.InStock = true;
            TestItem.OrderID = PrimaryKey;
            TestItem.OrderlineId = rnd.Next();
            TestItem.OrderPrice = 69.42;
            TestItem.Quantity = 3;
            TestItem.TotalPayable = 34.4;
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem; //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Random rnd = new Random();
            Int32 PrimaryKey = rnd.Next();
            //set its properties
            TestItem.CustomerID = 28538192;
            TestItem.GameName = "test";
            TestItem.OrderDate = DateTime.Today.Date;
            TestItem.GamePrice = 24.44;
            TestItem.InStock = true;
            TestItem.OrderID = PrimaryKey;
            TestItem.OrderlineId = rnd.Next();
            TestItem.OrderPrice = 69.42;
            TestItem.Quantity = 3;
            TestItem.TotalPayable = 34.4;
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem; //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;

            TestItem.CustomerID = 42784228;
            TestItem.GameName = "testi";
            TestItem.OrderDate = DateTime.Today.Date;
            TestItem.GamePrice = 24.46;
            TestItem.InStock = false;
            TestItem.OrderPrice = 69.42;
            TestItem.Quantity = 7;
            TestItem.TotalPayable = 34.4;
            //find the record
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert. AreEqual(AllOrders. ThisOrder, TestItem);
        }
        
    }


}