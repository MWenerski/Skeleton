using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        //'Good data'
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
            int staffId = 3;
            //Invoke the method
            found = aStaff.Find(staffId);
            //Check available to work
            if (aStaff.availableToWork != true)
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
            //test an hours worked that is extremely below min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "-200";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "The Hours Worked can not be a negative number: ");
        }

        [TestMethod]
        public void HoursWorkedMinMinusOne()
        {
            //Test an hours worked that is one below min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "-1";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "The Hours Worked can not be a negative number: ");
        }

        [TestMethod]
        public void HoursWorkedMin()
        {
            //Test an hours worked that is on min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "0";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HoursWorkedMinplusOne()
        {
            //Test an hours worked that one over min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "1";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void HoursWorkedNotBlank()
        {
            //test an hours worked that is blank
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hours worked may be blank Hours Worked must be a valid decimal ");
        }

        [TestMethod]
        public void HoursWorkedMid()
        {
            //test an hours worked that is in the middle
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "24";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HoursWorkedMaxMinusOne()
        {
            //Test an hours worked one below max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "47";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void HoursWorkedMax()
        {
            //Test an hours worked on max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "48";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HoursWorkedMaxPlusOne()
        {
            //Test an hours worked one over max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "500";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "The Hours Worked can not be greater than 48: ");
        }

        [TestMethod]
        public void HoursWorkedExtremeMax()
        {
            //Test an hours worked that is extremely over max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "1000";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "The Hours Worked can not be greater than 48: ");
        }


        [TestMethod]
        public void HoursWorkedInvalidDataType1()
        {
            //Test an hours worked that is a string
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "hello";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hours Worked must be a valid decimal ");
        }

        [TestMethod]
        public void HoursWorkedInvalidDataType2()
        {
            //Test an hours worked that is a boolean
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "true";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hours Worked must be a valid decimal ");
        }

        [TestMethod]
        public void HoursWorkedInvalidDataType3()
        {
            //Test an hours worked that is a character
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hoursWorked = "c";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hours Worked must be a valid decimal ");
        }

        [TestMethod]
        public void HourlyWageExtremeMin()
        {
            //Test an hourly wage extremely below the min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "-200";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage can not be below the minimum wage(5.28): ");
        }

        [TestMethod]
        public void HourlyWageMinMinusOne()
        {
            //Test an hourly wage one below min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "4.28";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage can not be below the minimum wage(5.28): ");
        }

        [TestMethod]
        public void HourlyWageMin()
        {
            //test an hourly wage on min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "5.28";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void HourlyWageMinPlusOne()
        {
            //Test a hourly wage that is one above min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "6.28";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HourlyWageNotBlank()
        {
            //Test a blank hourly wage
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly wage may be blank Hourly Wage must be a valid decimal ");
        }

        [TestMethod]
        public void HourlyWageMid()
        {
            //Test an hourly wage in the middle
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "52.64";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HourlyWageMaxMinusOne()
        {
            //Test an hourly wage one below max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "99";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HourlyWageMax()
        {
            //Test an hourly wage that is on max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "100";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HourlyWageMaxplusOne()
        {
            //Test an hourlywage that is one above max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "101";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage can not be greater than 100: ");
        }

        [TestMethod]
        public void HourlyWageExtremeMax()
        {
            //Test an hourlywage that is extremely over max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "1000";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage can not be greater than 100: ");
        }

        [TestMethod]
        public void HourlyWageInvalidDataType1()
        {
            //Test an Hourly wage that is a string
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "hello";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage must be a valid decimal ");
        }

        [TestMethod]
        public void HourlyWageInvalidDataType2()
        {
            //Test an hourly wage that is a boolean
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "false";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage must be a valid decimal ");
        }

        [TestMethod]
        public void HourlyWageInvalidDataType3()
        {
            //Test an hourly wage that is a character
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = "c";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage must be a valid decimal ");
        }
        
        [TestMethod]
        public void HourlyWageStaringWithSpace()
        {
            //Test an hourly wage starting with a space
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string hourlyWage = " 52.64";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Hourly Wage can not start with a space ");
        }

        [TestMethod]
        public void NameMinMinusOne()
        {
            //Test a name that is one below min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Name may be blank ");
        }

        [TestMethod]
        public void NameMin()
        {
            //test a name that is on the min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "A";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //Test a name that is min plus one
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //Test a name that is in the middle
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            //Test a name that is one below the max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //Test a name that is on the max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //Test a name that is one over the max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Name has be 50 characters or less ");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //Test a name extremely over the max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Name has be 50 characters or less ");
        }

        [TestMethod]
        public void NameStartingWithSpace()
        {
            //Test a name that starts with a space
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string name = " AAAAAAAAAAAAAAAAAAAAAAAAA";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Name can not start with a space ");
        }

        [TestMethod]
        public void PhoneNumberExtremeMin()
        {
            //Test a phonenumber extremely below the min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number may be blank ");
        }

        [TestMethod]
        public void PhoneNumberMinMinusOne()
        {
            //Test a phone number on below the min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "023456";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number has to be at least 7 characters ");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //Test a phonenumber on the min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0234567";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //Test a phone number one above the min
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "02345678";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMaxMinusOne()
        {
            //Test a phonenumber one below the max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0245678900";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //Test a phonenumber that is on the max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "023456789000";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //Test a phonenumber that is one over the max
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0234567890000";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number must be at most 12 characters ");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //Test a phonenumber extremely over the max characters
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0234567890012345678900123456789001234567890012345678900123456789001234567890012345678900123456789001234567890012345678900123456789001234567";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number must be at most 12 characters ");
        }

        [TestMethod]
        public void PhoneNumberEndingWithLetter()
        {
            //Test a phone number that ends with a letter
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0121356A";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number should only contain numerical values, + or a space ");
        }

        public void PhoneNumberMidLetter()
        {
            //Test a phonenumber that has a letter in the middle of it
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0121A356";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number should only contain numerical values, + or a space");
        }

        public void PhoneNumberStartingLetter()
        {
            //Test a phonenumber that starts with an invalid character
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "A0121356";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "Phone Number should only contain numerical values, + or a space");
        }

        [TestMethod]
        public void PhoneNumberStartingWithPlus()
        {
            //Test a phone number starting with a '+'
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "+44121356";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void PhoneNumberWithSpace()
        {
            //Test a phone number that has a space in it
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = "0121 4356";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberStartsWithSpace()
        {
            //Test a phonenumber that starts with a space
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string phoneNumber = " 01214356";
            Error = aStaff.Valid(hoursWorked, hourlyWage, phoneNumber, name, dateStarted);
            Assert.AreEqual(Error, "PhoneNumber can not start with a space ");
        }

        [TestMethod]
        public void DateExtremeMin()
        {
            //Test a date that is extremely below the min
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
            //Test a date that is one below the min
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
            //Test a date that is on the min
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
            //Test a date one over the min
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
            //Test a date one below the max
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
            //Test a date on the max
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
            //Test a date one over max
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
            //Test a date extremely over max
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
