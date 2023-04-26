using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {

        //good test data
        //create some test data to pass to the method
        String SupplierName = "name";
        String Email = "email";
        String DateAdded = DateTime.Now.Date.ToString();
        String ContactNumber = "ContactNumber";
        String Address = "Address";


        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(InSupplier);
        }
        [TestMethod]
        public void SupplierNameOk()
        {
            clsSupplier InSupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "";
            //assign the data to the property
            InSupplier.SupplierName = TestData;
            //test to see that two values are the same
            Assert.AreEqual(InSupplier.SupplierName, TestData);
        }
        [TestMethod]
        public void IDPropertyOk()
        {
            clsSupplier InSupplier = new clsSupplier();
            int TestData = 1;
            InSupplier.ID = TestData;
            Assert.AreEqual(InSupplier.ID, TestData);
        }
        [TestMethod]
        public void EmailPropertyOk()
        {
            clsSupplier InSupplier = new clsSupplier();
            String TestData = "";
            InSupplier.Email = TestData;
            Assert.AreEqual(InSupplier.Email, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOk()
        {
            clsSupplier InSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            InSupplier.DateAdded = TestData;
            Assert.AreEqual(InSupplier.DateAdded, TestData);

        }
        [TestMethod]
        public void ContactNumberPropertyOk()
        {
            clsSupplier InSupplier = new clsSupplier();
            string TestData = "";
            InSupplier.ContactNumber = TestData;
            Assert.AreEqual(InSupplier.ContactNumber, TestData);
        }
        [TestMethod]
        public void AddressPropertyOk()
        {
            clsSupplier InSupplier = new clsSupplier();
            String TestData = "";
            InSupplier.Address = TestData;
            Assert.AreEqual(InSupplier.Address, TestData);
        }
        [TestMethod]
        public void OngoingContractPropertyOk()
        {
            clsSupplier InSupplier = new clsSupplier();
            bool TestData = true;
            InSupplier.OngoingContract = TestData;
            Assert.AreEqual(InSupplier.OngoingContract, TestData);
        }
        [TestMethod]
        public void FindMethodOk()
        {
            clsSupplier InSupplier = new clsSupplier();
            Boolean Found = false;
            int ID = 2;
            Found = InSupplier.Find(ID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestIDFound()
        {
            clsSupplier InSupplier = new clsSupplier();
            //boolean variable to store the result of the research
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            int ID = 2;
            Found = InSupplier.Find(ID);
            //Check the ID
            if (InSupplier.ID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier InSupplier = new clsSupplier();
            //boolean variable to store the result of the research
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creqte some test data to use with the method
            int ID = 2;
            Found = InSupplier.Find(ID);
            //Check the ID
            if (InSupplier.SupplierName != "Asma")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            clsSupplier InSupplier = new clsSupplier();
            //boolean variable to store the result of the research
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creqte some test data to use with the method
            int ID = 2;
            Found = InSupplier.Find(ID);
            //Check the ID
            if (InSupplier.Email != "asma@")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsSupplier InSupplier = new clsSupplier();
            //boolean variable to store the result of the research
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creqte some test data to use with the method
            int ID = 2;
            Found = InSupplier.Find(ID);
            //Check the ID
            if (InSupplier.DateAdded != Convert.ToDateTime("14/09/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContactNumberFound()
        {
            clsSupplier InSupplier = new clsSupplier();
            //boolean variable to store the result of the research
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creqte some test data to use with the method
            int ID = 2;
            Found = InSupplier.Find(ID);
            //Check the ID
            if (InSupplier.ContactNumber != "JGG98")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            clsSupplier InSupplier = new clsSupplier();
            //boolean variable to store the result of the research
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creqte some test data to use with the method
            int ID = 2;
            Found = InSupplier.Find(ID);
            //Check the ID
            if (InSupplier.Address != "Tangier")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOngoingContractFound()
        {
            clsSupplier InSupplier = new clsSupplier();
            //boolean variable to store the result of the research
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creqte some test data to use with the method
            int ID = 2;
            Found = InSupplier.Find(ID);
            //Check the ID
            if (InSupplier.OngoingContract != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier InSupplier = new clsSupplier();
            String Error = "";
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = ""; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "a"; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "aa"; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(19, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMax()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(20, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(21, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMid()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(10, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa"; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(19, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(20, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(21, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(10, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(500, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
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
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
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
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
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
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            String DateAdded = "this is not a date!";
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = ""; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMin()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "a"; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "aa"; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(14, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMax()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(15, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(16, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMid()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(8, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(500, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aa"; //this should be ok
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(49, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(50, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(51, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier InSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(500, 'a');
            //invoke the method
            Error = InSupplier.Valid(SupplierName, Email, DateAdded, ContactNumber, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
    }
