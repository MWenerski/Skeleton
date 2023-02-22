using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);

        }
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
        public void DateCreatedOK() {
            //Create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAddress.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.DateAdded, TestData);
        }
        //email, password, username - varchar(50)
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
        //customerID - int
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
    }
}
