using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
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
            int TestData = 1;
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


    }
}
