using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //int CustomerID = 17;
        string Username = "Gamer24";
        string Password = "password";
        string Email = "Gamer24@gmail.com";
        string DateAdded = DateTime.Today.ToString();

        // Added 22/02/2023

        [TestMethod]
        public void TestMethodDB()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            bool r = AnCustomer.CheckDataBase();

            //test to see that it exists
            Assert.IsTrue(r);

        }

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
            Int32 CustomerID = 11;
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
            Int32 CustomerID = 17;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.CustomerID != 17)
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
            Int32 CustomerID = 17;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Username != "Bad")
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
            Int32 CustomerID = 17;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Password != "Man")
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
            Int32 CustomerID = 17;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Email != "BM@gmail.com")
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
            Int32 CustomerID = 17;
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
            Int32 CustomerID = 17;
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.DateAdded != Convert.ToDateTime("01/01/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //=================================================================================
        //test valid method
        [TestMethod]
        public void ValidMethodOK() 
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        //test Username "Gamer24"/12b - min 1, max 10
        [TestMethod]
        public void UsernameMin() 
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Username = "a";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void UsernameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Username = "aa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void UsernameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Username = "aaaaaaaaa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void UsernameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Username = "aaaaaaaaaa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Username = "aaaaaaaaaaa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreNotEqual(error, "");     //should fail
        }

        [TestMethod]
        public void UsernameNoMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Username = "aaaaa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void UsernameNoExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Username = "";
            Username = Username.PadRight(500, 'a'); //should fail
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreNotEqual(error, "");     //should fail
        }

        //test DateAdded ----------------------------------------------------------
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Today.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToShortDateString();
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreNotEqual(error, "");         //should fail
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Today.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreNotEqual(error, "");      //should fail
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Today.Date;
            //TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Today.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreNotEqual(error, "");      //should fail
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Today.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreNotEqual(error, "");         //should fail
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Today.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = "this is not a date!";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreNotEqual(error, "");      //should fail
        }

        //test Password ---------------------------------------------------------------------
        //test  string Password = "password";

        [TestMethod]
        public void PasswordMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Password = "a";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Password = "aa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Password = "aaaaaaaaa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Password = "aaaaaaaaaa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Password = "aaaaaaaaaaa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreNotEqual(error, "");     //shoulf fail
        }

        [TestMethod]
        public void PasswordNoMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Password = "aaaaa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordNoExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Password = "";
            Username = Username.PadRight(500, 'a'); //should fail
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreNotEqual(error, "");
            
        }

        //test Email --------------------------------------------------------------------
        //test string Email = "Gamer24@gmail.com";
        [TestMethod]
        public void EmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Email = "a";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Email = "aa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Email = "aaaaaaaaaaaaaaaaaaa";    //19
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Email = "aaaaaaaaaaaaaaaaaaa";    //20
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Email = "aaaaaaaaaaaaaaaaaaaaa";  //21
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailNoMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Email = "aaaaaaaaaa";
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailNoExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            string Email = "";
            Username = Username.PadRight(500, 'a'); //should fail
            error = AnCustomer.Valid(Username, Password, Email, DateAdded);
            Assert.AreNotEqual(error, "");     //should fail
        }
    }
}
