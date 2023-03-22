using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TestMethodIsNotNull()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.InStock = TestData;
            Assert.AreEqual(AnOrder.InStock, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }

        [TestMethod]
        public void GamePricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Double TestData = 49.99;
            //assign the data to the property
            AnOrder.GamePrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.GamePrice, TestData);
        }

        [TestMethod]
        public void OrderPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Double TestData = 49.99;
            //assign the data to the property
            AnOrder.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void TotalToPayPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Double TestData = 49.99;
            //assign the data to the property
            AnOrder.TotalPayable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPayable, TestData);
        }

        [TestMethod]
        public void GameNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Ultimate Chicken Horse";
            //assign the data to the property
            AnOrder.GameName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.GameName, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "63Ue57A";
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 6337852;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 TestNo = 21;
            Found = AnOrder.Find(TestNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderID != "343988")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.Quantity != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.TotalPrice != 49.99)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGameNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.GameName != "sussy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGamePriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.GamePrice != 49.98)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPayableFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.TotalPayable != 49.98)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.CustomerID != 4998)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.InStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
