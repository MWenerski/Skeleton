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
            Assert.AreEqual(Error, "");
        }



    }
}
