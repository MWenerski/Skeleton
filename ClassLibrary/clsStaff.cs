using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int staffId
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
            DB.addParameter("@StaffId", staffId);
            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //If one record is found
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private date members
                mstaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mHourlyWage = Convert.ToDouble(DB.DataTables.Rows[0]["HourlyWage"]);
                mHoursWorked = Convert.ToDouble(DB.DataTables.Rows[0]["HoursWorked"]);
                mPhoneNumber = Convert.ToString(DB.DataTables.Rows[0]["PhoneNumber"]);
                mName = Convert.ToString(DB.DataTables.Rows[0]["StaffName"]);
                mDateStarted = Convert.ToDateTime(DB.DataTables.Rows[0]["DateJoined"]);
                mAvailableToWork = Convert.ToBoolean(DB.DataTables.Rows[0]["AvailableToWork"]);

                return true;
            } else
            {
                return false;
            }

        }
    }
}