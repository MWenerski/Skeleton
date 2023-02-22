using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            // creates a new instance of the class
            clsStock AStock = new clsStock();
            // testing to see if the class exists
            Assert.IsNotNull(AStock);
        }
    }

    public class clsStock
    {
    }
}
