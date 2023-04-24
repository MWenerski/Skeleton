using System;
using System.Text.RegularExpressions;


namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffId
        {
            get
            {
                return mstaffId;
            }
            set
            {
                mstaffId = value;
            }
        }


        private int mstaffId;
       

        private bool mAvailableToWork;
        public bool availableToWork
        {
            get
            {
                return mAvailableToWork;
            }
            set
            {
                mAvailableToWork = value;
            }
        }
        private DateTime mDateStarted;
        public DateTime dateStarted
        {
            get
            {
                return mDateStarted;
            }
            set
            {
                mDateStarted = value;
            }
        }
        private String mPhoneNumber;
        public string phoneNumber
        {
            get
            {
                return mPhoneNumber;
            }

            set
            {
                mPhoneNumber = value;
            }
        }
        private double mHourlyWage;
        public double hourlyWage
        {
            get
            {
                return mHourlyWage;
            }
            set
            {
                mHourlyWage = value;
            }
        }
        private double mHoursWorked;
        public double hoursWorked
        {
            get
            {
                return mHoursWorked;
            }
            set
            {
                mHoursWorked = value;
            }
        }
        private string mName;
        public string name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public bool Find(int staffId)
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Addthe parameter for the staffId no to search for
            DB.AddParameter("@StaffId", staffId);
            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //If one record is found
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mstaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mHoursWorked = Convert.ToDouble(DB.DataTable.Rows[0]["HoursWorked"]);
                mHourlyWage = Convert.ToDouble(DB.DataTable.Rows[0]["HourlyWage"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mDateStarted = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mAvailableToWork = Convert.ToBoolean(DB.DataTable.Rows[0]["AvailableToWork"]);

                return true;
            } else
            {
                return false;
            }

        }
        
        public string Valid(string _hoursWorked, string _hourlyWage, string _phoneNumber, string _name, string _dateStarted)
        {
            String Error = "";

            double tempDouble;
            bool letterCheck = false;
            DateTime tempDate;
            
            //check to see that the number entered is not blank
            if (_hoursWorked.Length == 0)
            {
                Error = Error + "Hours worked may be blank ";
                
            }
            try
            {
                //check to see if the number entered is positive
                tempDouble = Convert.ToDouble(_hoursWorked);
                if (tempDouble < 0)
                {
                    //record the error
                    Error = Error + "The Hours Worked can not be a negative number: ";
                }
                //check to if the number entered is greater than the max
                if (tempDouble > 48)
                {
                    //record the error
                    Error = Error + "The Hours Worked can not be greater than 48: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "Hours Worked must be a valid decimal ";
            }

            // Make sure input is not blank
            if (_hourlyWage.Length == 0)
            {
                Error = Error + "Hourly wage may be blank ";
                
            }
            try
            {
                
                tempDouble = Convert.ToDouble(_hourlyWage);
                //check to see if the number entered is at least the minimum wage
                if (tempDouble < 5.28)
                {
                    //record the error
                    Error = Error + "Hourly Wage can not be below the minimum wage(5.28): ";
                }
                //check to if the number entered is greater than the max
                if (tempDouble > 100)
                {
                    //record the error
                    Error = Error + "Hourly Wage can not be greater than 100: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "Hourly Wage must be a valid decimal ";
            }
            //Make sure name has a valid amount of characters
            if(_name.Length == 0)
            {
                Error = Error + "Name may be blank ";
            } else if(_name.Length > 50)
            {
                Error = Error + "Name has be 50 characters or less ";
            }

            //Make sure phonenumber has a valid amount of characters
            if (_phoneNumber.Length == 0)
            {
                Error = Error + "Phone Number may be blank ";
            } else if (_phoneNumber.Length > 10)
            {
                Error = Error + "Phone Number must be at most 10 characters ";
            } else if (_phoneNumber.Length < 7)
            {
                Error = Error + "Phone Number has to be at least 7 characters ";
            }
            //Makes sure Phone Number starts with a + or 0
            if (!_phoneNumber.StartsWith("0") && !_phoneNumber.StartsWith("+")){
                Error = Error + "Phone number must start with 0 or + ";
            }
            //Make sure that Phone Number is only valid characters
            for (int i = 0; _phoneNumber.Length > i; i++)
            {
                if(_phoneNumber[i] > 57 || _phoneNumber[i] < 48 && _phoneNumber[i] != 32)
                {
                    if(i == 0 && _phoneNumber[i] == 43)
                    {
                        
                    } else
                    {
                        letterCheck = true;
                    } 
                    
                }
            }
            if(letterCheck == true)
            {
                Error = Error + "Phone Number should only contain numerical values, + or a space ";
            }

            if(_dateStarted.Length == 0)
            {
                Error = Error + "Date Started may be blank ";
            }
            tempDate = Convert.ToDateTime(_dateStarted);
            if (tempDate < DateTime.Now.Date)
            {
                Error = Error + "The date can not be in the past ";
            } else if(tempDate > DateTime.Now.Date.AddYears(1))
            {
                Error = Error + "Date can only be at most a year in the furture ";
            }

            
           
            return Error;
    
        }
    }
}