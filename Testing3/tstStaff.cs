using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        string hourlyWage = "9";
        string hoursWorked = "45";
        string phoneNumber = "01234567";
        string name = "Bradley Walsh";
        string dateStarted = DateTime.Now.Date.ToString();

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
            Staff1.hourlyWage = testData;
            //Test to see if the two values are the same
            Assert.AreEqual(Staff1.hourlyWage, testData);
        }

        [TestMethod]
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

        [TestMethod]
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
            if (aStaff.phoneNumber != "06897 12345")
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
            if (aStaff.hourlyWage != 22)
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
            if (aStaff.hoursWorked != 2.5)
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
            //Make sure the valid method returns the correct string using only good data
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            String Error = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HoursWorkedExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "-200";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "The Hours Worked can not be a negative number: ");
        }

        [TestMethod]
        public void HoursWorkedMinMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "-1";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "The Hours Worked can not be a negative number: ");
        }

        [TestMethod]
        public void HoursWorkedMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "0";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HoursWorkedMinplusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "1";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void HoursWorkedNotBlank()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hours worked may be blank Hours Worked must be a valid decimal ");
        }

        [TestMethod]
        public void HoursWorkedMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "24";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HoursWorkedMaxMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "47";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void HoursWorkedMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "48";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HoursWorkedMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "500";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "The Hours Worked can not be greater than 48: ");
        }

        [TestMethod]
        public void HoursWorkedExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "1000";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "The Hours Worked can not be greater than 48: ");
        }


        [TestMethod]
        public void HoursWorkedInvalidDataType1()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "hello";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hours Worked must be a valid decimal ");
        }

        [TestMethod]
        public void HoursWorkedInvalidDataType2()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "true";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hours Worked must be a valid decimal ");
        }

        [TestMethod]
        public void HoursWorkedInvalidDataType3()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "c";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hours Worked must be a valid decimal ");
        }

        [TestMethod]
        public void HourlyWageExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "-200";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage can not be below the minimum wage(5.28): ");
        }

        [TestMethod]
        public void HourlyWageMinMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "4.28";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage can not be below the minimum wage(5.28): ");
        }

        [TestMethod]
        public void HourlyWageMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "5.28";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void HourlyWageMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "6.28";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HourlyWageNotBlank()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly wage may be blank Hourly Wage must be a valid decimal ");
        }

        [TestMethod]
        public void HourlyWageMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "52.64";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HourlyWageMaxMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "99";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HourlyWageMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "100";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HourlyWageMaxplusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "101";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage can not be greater than 100: ");
        }

        [TestMethod]
        public void HourlyWageExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "1000";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage can not be greater than 100: ");
        }

        [TestMethod]
        public void HourlyWageInvalidDataType1()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "hello";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage must be a valid decimal ");
        }

        [TestMethod]
        public void HourlyWageInvalidDataType2()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "false";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage must be a valid decimal ");
        }

        [TestMethod]
        public void HourlyWageInvalidDataType3()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "c";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage must be a valid decimal ");
        }

        [TestMethod]
        public void NameMinMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Name may be blank ");
        }

        [TestMethod]
        public void NameMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "A";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Name has be 50 characters or less ");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Name has be 50 characters or less ");
        }

        [TestMethod]
        public void PhoneNumberExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number may be blank Phone number must start with 0 or + ");
        }

        [TestMethod]
        public void PhoneNumberMinMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "023456";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number has to be at least 7 characters ");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0234567";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "02345678";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMaxMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0245678900";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "023456789000";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0234567890000";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number must be at most 12 characters ");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0234567890012345678900123456789001234567890012345678900123456789001234567890012345678900123456789001234567890012345678900123456789001234567";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number must be at most 12 characters ");
        }

        [TestMethod]
        public void PhoneNumberEndingWithLetter()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0121356A";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number should only contain numerical values, + or a space ");
        }

        public void PhoneNumberEndingMidLetter()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0121A356";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number should only contain numerical values, + or a space");
        }

        [TestMethod]
        public void PhoneNumberStartingWithPlus()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "+44121356";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void PhoneNumberWithSpace()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0121 4356";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(-100);
            string dateStarted = testDate.ToString();
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "The date can not be in the past ");
        }

        [TestMethod]
        public void DateMinMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(-1);
            string dateStarted = testDate.ToString();
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "The date can not be in the past ");
        }

        [TestMethod]
        public void DateMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime testDate = DateTime.Now.Date;
            string dateStarted = testDate.ToString();
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(1);
            string dateStarted = testDate.ToString();
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void DateMaxMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(1).AddDays(-1);
            string dateStarted = testDate.ToString();
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(1);
            string dateStarted = testDate.ToString();
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(1).AddDays(1);
            string dateStarted = testDate.ToString();
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Date can only be at most a year in the furture ");
        }

        [TestMethod]
        public void DateExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            DateTime testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(100);
            string dateStarted = testDate.ToString();
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Date can only be at most a year in the furture ");
        }

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Test to see if it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //Create the item of test data
            clsStaff TestItem = new clsStaff();
            //Set its properties
            TestItem.availableToWork = true;
            TestItem.dateStarted = DateTime.Now.Date;
            TestItem.StaffId = 1;
            TestItem.name = "James Conway";
            TestItem.phoneNumber = "079213444";
            TestItem.hourlyWage = 10;
            TestItem.hoursWorked = 30;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStaff.StaffList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

 

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //Set the properties of the test object
            TestStaff.availableToWork = true;
            TestStaff.dateStarted = DateTime.Now.Date;
            TestStaff.StaffId = 1;
            TestStaff.name = "James Conway";
            TestStaff.phoneNumber = "079213444";
            TestStaff.hourlyWage = 10;
            TestStaff.hoursWorked = 30;
            //Assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //Test to see that two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //Create the item of test data
            clsStaff TestItem = new clsStaff();
            //Set its properties
            TestItem.availableToWork = true;
            TestItem.dateStarted = DateTime.Now.Date;
            TestItem.StaffId = 1;
            TestItem.name = "James Conway";
            TestItem.phoneNumber = "079213444";
            TestItem.hourlyWage = 10;
            TestItem.hoursWorked = 30;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create the item of test data
            clsStaff TestItem = new clsStaff();
            //Var to store the primary key
            Int32 primaryKey = 0;
            //Set its properties
            TestItem.availableToWork = true;
            TestItem.dateStarted = DateTime.Now.Date;
            TestItem.StaffId = 4;
            TestItem.name = "James Conway";
            TestItem.phoneNumber = "079213444";
            TestItem.hourlyWage = 10;
            TestItem.hoursWorked = 30;
            //Set ThisStaff to this test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            primaryKey = AllStaff.Add();
            //Set the primary key of the test data
            TestItem.StaffId = primaryKey;
            //Find the record
            AllStaff.ThisStaff.Find(primaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create the item of test data
            clsStaff TestItem = new clsStaff();
            //Var to store the primary key
            Int32 primaryKey = 0;
            //Set its properties
            TestItem.availableToWork = false;
            TestItem.dateStarted = DateTime.Now.Date;
            TestItem.name = "Francis Collola";
            TestItem.phoneNumber = "079213555";
            TestItem.hourlyWage = 10.5;
            TestItem.hoursWorked = 30.1;
            //Set ThisStaff to this test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            primaryKey = AllStaff.Add();
            //Set the primary key of the test data
            TestItem.StaffId = primaryKey;
            //Modilfy the test data
            TestItem.availableToWork = true;
            TestItem.dateStarted = DateTime.Now.Date.AddDays(1);
            TestItem.name = "Francis Coppola";
            TestItem.phoneNumber = "079213666";
            TestItem.hourlyWage = 15.1;
            TestItem.hoursWorked = 10.3;
            //Set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //Update the record
            AllStaff.Update();
            //Find the record
            AllStaff.ThisStaff.Find(primaryKey);
            //Test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create the item of test data
            clsStaff TestItem = new clsStaff();
            //Var to store the primary key
            Int32 primaryKey = 0;
            //Set its properties
            TestItem.availableToWork = false;
            TestItem.dateStarted = DateTime.Now.Date;
            TestItem.name = "Francis Collola";
            TestItem.phoneNumber = "079213555";
            TestItem.hourlyWage = 10.5;
            TestItem.hoursWorked = 30.1;
            //Set ThisStaff to this test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            primaryKey = AllStaff.Add();
            //Set the primary key of the test data
            TestItem.StaffId = primaryKey;
            //Find the record
            AllStaff.ThisStaff.Find(primaryKey);
            //Delete this record
            AllStaff.Delete();
            //Now find the record
            Boolean Found = AllStaff.ThisStaff.Find(primaryKey);
            //Test to make sure that the record is not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOk()
        {
            //Create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create an instance of the unfiltered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //Apply a blank string, Should return all records
            FilteredStaff.ReportsByName("");
            //Test to see the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //Create an instance of filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //Appply a name that doesnt exist
            FilteredStaff.ReportsByName("TFIYGKUL ");
            //Test to make sure there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void PeportByNameTestDataFound()
        {
            //Create an instance of the filtered data
            clsStaffCollection FiliteredStaff = new clsStaffCollection();
            //Var to store the outcome
            Boolean Ok = true;
            //Apply a name that does exist
            FiliteredStaff.ReportsByName("Paul");
            if (FiliteredStaff.Count == 1)
            {
                if(FiliteredStaff.StaffList[0].StaffId != 1)
                {
                    Ok = false;
                }
              
            } else
            {
                Ok = false;
            }
            //Test to see there are no records
            Assert.IsTrue(Ok);
        }
    }
}
