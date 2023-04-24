using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //Private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //Privaate data member for ThisStaff
        clsStaff mThisStaff = new clsStaff();
        //Public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //Set the private data
                mStaffList = value;
            }

        }
        public int Count
        {
            get
            {
                //Return the count of the list
                return mStaffList.Count;
            }
            set
            {

            }
        }

        //Public property for ThisStaff
        public clsStaff ThisStaff 
        {
            get
            {
                //Return the private data
                return mThisStaff;
            }
            set
            {
                //Set the private data
                mThisStaff = value;
            }
        }

        public clsStaffCollection()
        {
            //Var for the index
            Int32 Index = 0;
            //Var to store the record count
            Int32 RecordCount = 0;
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //Get the count of records
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                //Create a blank address
                clsStaff AStaff = new clsStaff();
                //Read in the fields from the current record
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.hoursWorked = Convert.ToDouble(DB.DataTable.Rows[Index]["HoursWorked"]);
                AStaff.hourlyWage = Convert.ToDouble(DB.DataTable.Rows[Index]["HourlyWage"]);
                AStaff.phoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AStaff.name = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.dateStarted = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                AStaff.availableToWork = Convert.ToBoolean(DB.DataTable.Rows[Index]["AvailableToWork"]);
                //Add the record to the private data member
                mStaffList.Add(AStaff);
                Index++;

            }
        }

        public int Add()
        {
            //Adds a new record to the database based on the values of mThisStaff
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@Staffname", mThisStaff.name);
            DB.AddParameter("@PhoneNumber", mThisStaff.phoneNumber);
            DB.AddParameter("@HourlyWage", mThisStaff.hourlyWage);
            DB.AddParameter("@HoursWorked", mThisStaff.hoursWorked);
            DB.AddParameter("@AvailableToWork", mThisStaff.availableToWork);
            DB.AddParameter("@DateJoined", mThisStaff.dateStarted);
            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //Update an existing record based on the values of thisStaff
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@Staffname", mThisStaff.name);
            DB.AddParameter("@PhoneNumber", mThisStaff.phoneNumber);
            DB.AddParameter("@HourlyWage", mThisStaff.hourlyWage);
            DB.AddParameter("@HoursWorked", mThisStaff.hoursWorked);
            DB.AddParameter("@AvailableToWork", mThisStaff.availableToWork);
            DB.AddParameter("@DateJoined", mThisStaff.dateStarted);
            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");

        }
    }
}