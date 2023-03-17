using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

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
    }
}
