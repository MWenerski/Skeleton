using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //Create an instance of the class
            clsStaff staff1 = new clsStaff();
            //Testing to see wether that exists
            Assert.IsNotNull(staff1);
        }

        [TestMethod]
        public void AvailableToWorPropertykOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff1 = new clsStaff();
            //Create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property
            Staff1.availableToWork = testData;
            //Test to see if the two values are the same
            Assert.AreEqual(Staff1.availableToWork, testData);
        }

        public void DateStartedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff1 = new clsStaff();
            //Create some test data to assign to the property
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            Staff1.dateStarted = testData;
            //Test to see if the two values are the same
            Assert.AreEqual(Staff1.dateStarted, testData);
        }

        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff1 = new clsStaff();
            //Create some test data to assign to the property
            String testData = "01975 1234875";
            //assign the data to the property
            Staff1.phoneNumber = testData;
            //Test to see if the two values are the same
            Assert.AreEqual(Staff1.phoneNumber, testData);
        }

        public void HourlyWagePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff1 = new clsStaff();
            //Create some test data to assign to the property
            double testData = 9.50;
            //assign the data to the property
            Staff1.hourlyWage = testData;
            //Test to see if the two values are the same
            Assert.AreEqual(Staff1.hourlyWage, testData);
        }

        public void HoursWorkedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff1 = new clsStaff();
            //Create some test data to assign to the property
            double testData = 10.50;
            //assign the data to the property
            Staff1.hoursWorked = testData;
            //Test to see if the two values are the same
            Assert.AreEqual(Staff1.hoursWorked, testData);
        }

        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff1 = new clsStaff();
            //Create some test data to assign to the property
            String testData = "John Smith";
            //assign the data to the property
            Staff1.name = testData;
            //Test to see if the two values are the same
            Assert.AreEqual(Staff1.name, testData);
        }


    }
}
