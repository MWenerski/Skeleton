using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstName
    {
        [TestMethod]
        public void InstanceOk()
        {
            //Create an instance of the class
            clsStaff staff1 = new clsStaff();
            //Testing to see wether that exists
            Assert.IsNotNull(staff1);
        }
    }
}
