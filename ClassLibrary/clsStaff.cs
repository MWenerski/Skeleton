using System;

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
        public bool AvailableToWork
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
        public DateTime DateStarted
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
        public string PhoneNumber
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
        public double HourlyWage
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
        public double HoursWorked
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
        public string Name
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
                //Copy the data from the database to the private date members
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
        
        public string Valid(string hoursWorked, string hourlyWage, string phoneNumber, string name)
        {
            String Error = "";
            if (hoursWorked.Length == 0)
            {
                Error = Error + "Hours worked may be blank";
            }

            return Error;
        }
    }
}