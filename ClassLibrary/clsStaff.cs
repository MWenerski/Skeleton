using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int staffId { get; }
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
            //Dummy
            staffId = 15;
            return true;
        }
    }
}