using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //test instantiation of the class clsCustomer
        [TestMethod]
        public void TestMethod1()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);

        }

        //test verified
        [TestMethod]
        public void VerifiedPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAddress.Verified = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Verified, TestData);
        }

        //DateCreated - datetime
        [TestMethod]
        public void DateCreated()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAddress.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.DateAdded, TestData);
        }

        //test email
        [TestMethod]
        public void EmailOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "customer@gmail.com";
            //assign the data to the property
            AnAddress.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Email, TestData);
        }

        //test password
        [TestMethod]
        public void PasswordOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "password";
            //assign the data to the property
            AnAddress.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Password, TestData);
        }

        //test Username
        [TestMethod]
        public void UsernameOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "DilanGray";
            //assign the data to the property
            AnAddress.Username = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Username, TestData);
        }

        //test customerID - int
        [TestMethod]
        public void CustomerIDOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.CustomerID, TestData);
        }

        //--------------------------------------------------------------
        //Find method
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        //Find CustomerID
        [TestMethod]
        public void testCustomerIDFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Find username
        [TestMethod]
        public void testUsernameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Username != "Knight98")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Find password
        [TestMethod]
        public void testPasswordFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Password != "12345")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //find Email
        [TestMethod]
        public void testEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Email != "knight98@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //find verified
        [TestMethod]
        public void testVerifiedFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Verified != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //find dateAdded
        [TestMethod]
        public void testDateAddedFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
