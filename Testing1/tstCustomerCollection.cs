using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void testMethod1()
        {
        }
        //----------------------------------------------------------------------------------------------------------    
        //Creating the collection class
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        //CustomerList property
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 1;
            TestItem.Username = "john";
            TestItem.Password = "password";
            TestItem.Email = "John@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Verified = true;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        //Count Property OK
        [TestMethod]
        public void CountPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Int32 SomeCount = 2;
            AllCustomers.Count = SomeCount;
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        //This customer property OK
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CustomerID = 1;
            TestCustomer.Username = "john";
            TestCustomer.Password = "password";
            TestCustomer.Email = "John@gmail.com";
            TestCustomer.DateAdded = DateTime.Now.Date;
            TestCustomer.Verified = true;

            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        //tests if records can be added to the lists and count property correctly
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            //TestItem.Verified = true;
            TestItem.CustomerID = 1;
            TestItem.Username = "john";
            TestItem.Password = "password";
            TestItem.Email = "John@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Verified = true;
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.AreEqual(AllCustomers.Count, 2);
        }

        //Add method -------------------------------------------------------
        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Username = "Bad";
            TestItem.Password = "Man";
            TestItem.Email = "BM@gmail.com";
            TestItem.Verified = true;
            TestItem.DateAdded = DateTime.Today.Date;

            AllCustomers.ThisCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
    }


}