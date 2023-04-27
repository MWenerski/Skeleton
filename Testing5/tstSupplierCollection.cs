using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);
        }
        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property in this case a list
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.ID = 3;
            TestItem.SupplierName = "name";
            TestItem.Email = "email";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNumber = "contactnumber";
            TestItem.Address = "address";
            TestItem.OngoingContract = true;
            //add the test item
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);

        }
        /* [TestMethod]
         public void CountPropertyOK()
         {
             clsSupplierCollection AllSuppliers = new clsSupplierCollection();
             Int32 SomeCount = 2;
             AllSuppliers.Count = SomeCount;
             Assert.AreEqual(AllSuppliers.Count, SomeCount);
         }*/
        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            //set its properties
            TestSupplier.ID = 3;
            TestSupplier.SupplierName = "name";
            TestSupplier.Email = "email";
            TestSupplier.DateAdded = DateTime.Now.Date;
            TestSupplier.ContactNumber = "contactnumber";
            TestSupplier.Address = "address";
            TestSupplier.OngoingContract = true;
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property in this case a list
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.ID = 3;
            TestItem.SupplierName = "name";
            TestItem.Email = "email";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNumber = "contactnumber";
            TestItem.Address = "address";
            TestItem.OngoingContract = true;
            //add the test item
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ID = 3;
            TestItem.SupplierName = "name";
            TestItem.Email = "email";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNumber = "contactnumber";
            TestItem.Address = "address";
            TestItem.OngoingContract = true;
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.ID = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierName = "name1";
            TestItem.Email = "email1";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNumber = "contactnumber1";
            TestItem.Address = "address1";
            TestItem.OngoingContract = true;
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.ID = PrimaryKey;
            //modify the test data
            TestItem.SupplierName = "name2";
            TestItem.Email = "email2";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNumber = "contactnumber2";
            TestItem.Address = "address2";
            TestItem.OngoingContract = false;
            //set the record based on the new test data
            AllSuppliers.ThisSupplier = TestItem;
            //update the record
            AllSuppliers.Update();
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see thisSupplier matches the test data
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);



        }
    }
}
