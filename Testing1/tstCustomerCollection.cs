﻿using ClassLibrary;
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
            Int32 PrimaryKey = 17;
            TestItem.Username = "Bad";
            TestItem.Password = "Man";
            TestItem.Email = "BM@gmail.com";
            TestItem.Verified = true;
            TestItem.DateAdded = DateTime.Today.Date;
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        //update method
        [TestMethod]
        public void UpdateMethodOk() 
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Verified = true;
            TestItem.Username = "Tobi";
            TestItem.Password = "password";
            TestItem.Email = "Tobi@gmail.com";
            TestItem.DateAdded = DateTime.Today.Date;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.Verified = false;
            TestItem.Username = "Ryan";
            TestItem.Password = "username";
            TestItem.Email = "Ryan@gmail.com";
            TestItem.DateAdded = DateTime.Today.Date;

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        //Delete method
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Verified = true;
            TestItem.Username = "Josh";
            TestItem.Password = "password";
            TestItem.Email = "Josh@gmail.com";
            TestItem.DateAdded = DateTime.Today.Date;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        //field


        //Report By Username Method OK, NoneFound and TestDataFound
        [TestMethod]
        public void ReportByUsernameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByUsername("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByUsername("xxx xxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByUsernameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByUsername("yyy yyy");
            if(FilteredCustomers.Count == 2)
            {
                //check first to see if record 36 and 37 exisits
                if (FilteredCustomers.CustomerList[0].CustomerID != 36)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[1].CustomerID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }



}