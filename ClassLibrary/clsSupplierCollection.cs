using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
            
        public int Count 
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                //worry about this later
            }
            
        }
        clsSupplier mThisSupplier = new clsSupplier();
        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        //constructor
        public clsSupplierCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Selectall1");
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a new record to the database based on the values of ThisSupplier
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@ContactNumber", mThisSupplier.ContactNumber);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@OngoingContract", mThisSupplier.OngoingContract);
            //execute the query returning the primary key
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            //update an existing record  based on the values of ThisSupplier
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierID", mThisSupplier.ID);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@DateAdded", mThisSupplier.DateAdded);
            DB.AddParameter("@ContactNumber", mThisSupplier.ContactNumber);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@OngoingContract", mThisSupplier.OngoingContract);
            //execute the query returning the primary key
            DB.Execute("sproc_tblSupplier_Update");

        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.ID);
            DB.Execute("sproc_tblSupplier_Delete");
        }
        public void ReportByAddress(String Address)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Address", Address);
            DB.Execute("sproc_tblSupplier_FilterByAddressNo");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {

            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mSupplierList = new List<clsSupplier>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsSupplier InSupplier = new clsSupplier();
                //read the fields from the current record
                InSupplier.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                InSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                InSupplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                InSupplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                InSupplier.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                InSupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                InSupplier.OngoingContract = Convert.ToBoolean(DB.DataTable.Rows[Index]["OngoingContract"]);
                //add the record to the private data member
                mSupplierList.Add(InSupplier);
                Index++;
            }
        }
    }
}