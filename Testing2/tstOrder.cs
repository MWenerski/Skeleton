using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        string DateAdded = DateTime.Now.ToString();
        string Quantity = "3";
        string GamePrice = "34.99";
        string OrderPrice = "104.97";
        string TotalPayable = "104.97";
        string GameName = "Ori and the Will of the Wisps";
        string OrderID = "238";
        string CustomerID = "u2728ehb";

        [TestMethod]
        public void TestMethodIsNotNull()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testQuantity = 0;
            string Quantity = testQuantity.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");


        }
        
        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testQuantity = 1;
            string Quantity = testQuantity.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");
            
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testQuantity = 2;
            string Quantity = testQuantity.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testQuantity = 19;
            string Quantity = testQuantity.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testQuantity = 20;
            string Quantity = testQuantity.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testQuantity = 10;
            string Quantity = testQuantity.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testQuantity = 0;
            string Quantity = testQuantity.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlus500()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testQuantity = 520;
            string Quantity = testQuantity.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");
        }

        
        
        [TestMethod]
        public void GameNameMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameName = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameName = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GameNameMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GameNameMaxPlus500()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameName = "";//invoke the method
            GameName = GameName.PadRight(550, 'a');
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void OrderPriceMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testOrderPrice = 5000;
            string OrderPrice = testOrderPrice.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testOrderPrice = 10000;
            string OrderPrice = testOrderPrice.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void TotalPayableMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testTotalPayable = 5000;
            string TotalPayable = testTotalPayable.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GamePriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double testGamePrice = 100.00;
            string GamePrice = testGamePrice.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void GamePriceMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double testGamePrice = 50.00;
            string GamePrice = testGamePrice.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPayableMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 testTotalPayable = 10000;
            string TotalPayable = testTotalPayable.ToString();
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "34hb1"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "18hge282f1";//invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "72617"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "7183718992";//invoke the method
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(DateAdded, Quantity, GamePrice, OrderPrice, TotalPayable, GameName, OrderID, CustomerID);
            Assert.AreEqual(Error, "");
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
            Int32 OrderID = 21;
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
