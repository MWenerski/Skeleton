using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        string hourlyWage = "9";
        string hoursWorked = "55";
        string phoneNumber = "07960382145";
        string name = "Bradley Walsh";

        [TestMethod]
        public void InstanceOk()
        {
            //Create an instance of the class
            clsStaff staff1 = new clsStaff();
            //Testing to see wether that exists
            Assert.IsNotNull(staff1);
        }

        [TestMethod]
        public void AvailableToWorkPropertykOK()
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

        [TestMethod]
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

        [TestMethod]
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
        
        [TestMethod]
        public void HourlyWagePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff1 = new clsStaff();
            //Create some test data to assign to the property
            double testData = 9.50;
            //assign the data to the property
            Staff1.HourlyWage = testData;
            //Test to see if the two values are the same
            Assert.AreEqual(Staff1.HourlyWage, testData);
        }
        
        [TestMethod]
        public void HoursWorkedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff1 = new clsStaff();
            //Create some test data to assign to the property
            double testData = 10.50;
            //assign the data to the property
            Staff1.HoursWorked = testData;
            //Test to see if the two values are the same
            Assert.AreEqual(Staff1.HoursWorked, testData);
        }
       
        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff1 = new clsStaff();
            //Create some test data to assign to the property
            String testData = "John Smith";
            //assign the data to the property
            Staff1.Name = testData;
            //Test to see if the two values are the same
            Assert.AreEqual(Staff1.Name, testData);
        }
       
        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //Boolean variable to store results of the validation
            Boolean found = false;
            //Boolean variable to record if data is ok
            Boolean OK = true;
            //Create some test data
            int staffId = 1;
            //Invoke the method
            found = aStaff.Find(staffId);
            //Check the staff id
            if (aStaff.StaffId != 1)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindPhoneNumberOK()
        {
            //Create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //Boolean variable to store results of the validation
            Boolean found = false;
            //Boolean variable to record if data is ok
            Boolean OK = true;
            //Create some test data
            int staffId = 1;
            //Invoke the method
            found = aStaff.Find(staffId);
            //Check the phone number
            if (aStaff.PhoneNumber != "06897 12345")
            {
                OK = false;
            }
            //Test to see if the reuslt is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindHourlyWageOK()
        {
            //Create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //Boolean variable to store results of the validation
            Boolean found = false;
            //Boolean variable to record if data is ok
            Boolean OK = true;
            //Create some test data
            int staffId = 1;
            //Invoke the method
            found = aStaff.Find(staffId);
            //Check the hourly wage
            if (aStaff.HourlyWage != 22)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindHoursWorkedOK()
        {
            //Create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //Boolean variable to store results of the validation
            Boolean found = false;
            //Boolean variable to record if data is ok
            Boolean OK = true;
            //Create some test data
            int staffId = 1;
            //Invoke the method
            found = aStaff.Find(staffId);
            //Check the hours worked
            if (aStaff.HoursWorked != 2.5)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindNameOK()
        {
            //Create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //Boolean variable to store results of the validation
            Boolean found = false;
            //Boolean variable to record if data is ok
            Boolean OK = true;
            //Create some test data
            int staffId = 1;
            //Invoke the method
            found = aStaff.Find(staffId);
            //Check the name
            if (aStaff.name != "Paul Jones")
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindAvailableToWorkOK()
        {
            //Create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //Boolean variable to store results of the validation
            Boolean found = false;
            //Boolean variable to record if data is ok
            Boolean OK = true;
            //Create some test data
            int staffId = 1;
            //Invoke the method
            found = aStaff.Find(staffId);
            //Check available to work
            if (aStaff.availableToWork != false)
            {
                OK = false;
            }
            //Test to see if the reuslt is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindDateStartedOK()
        {
            //Create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //Boolean variable to store results of the validation
            Boolean found = false;
            //Boolean variable to record if data is ok
            Boolean OK = true;
            //Create some test data
            int staffId = 1;
            //Invoke the method
            found = aStaff.Find(staffId);
            //Check the date started
            if (aStaff.dateStarted != Convert.ToDateTime("2022-09-01"))
            {
                OK = false;
            }
            //Test to see if the reuslt is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HoursWorkedMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void HoursWorkedMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "0";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name);
            Assert.AreEqual(Error, "");
        }

    }
}
