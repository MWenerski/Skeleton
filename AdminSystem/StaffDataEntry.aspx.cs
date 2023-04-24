using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //Variable to store the primary key with the level scope
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of the adress to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //If this not a new record
            if (StaffId != -1)
            {
                //Display the current data for the record
                DisplayStaff();
            }
        }

    }
    void DisplayStaff()
    {
        //Create an instance of the Staff details
        clsStaffCollection StaffBook = new clsStaffCollection();
        //Find the record to update
        StaffBook.ThisStaff.Find(StaffId);
        //Display the data for this record
        txtStaffId.Text = StaffBook.ThisStaff.StaffId.ToString();
        txtHourlyWage.Text = StaffBook.ThisStaff.hourlyWage.ToString();
        txtHoursWorked.Text = StaffBook.ThisStaff.hoursWorked.ToString();
        txtStaffName.Text = StaffBook.ThisStaff.name;
        txtStaffPhoneNumber.Text = StaffBook.ThisStaff.phoneNumber;
        chckAvailableToWork.Checked = StaffBook.ThisStaff.availableToWork;
        lblDate.Text = StaffBook.ThisStaff.dateStarted.ToString();
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //Capture the data
        string Name = txtStaffName.Text;
        string PhoneNumber = txtStaffPhoneNumber.Text;
        string HourlyWage = txtHourlyWage.Text;
        string Hoursworked = txtHoursWorked.Text;
        string DateJoined = cldrDateJoined.SelectedDate.ToString();
        //Variable to store the error message
        string Error = "";
        //Validate the data
        Error = aStaff.Valid(Hoursworked, HourlyWage, PhoneNumber, Name, DateJoined);
        if (Error == "")
        {
            //Capture the data
            aStaff.StaffId = StaffId;
            aStaff.name = Name;
            aStaff.phoneNumber = PhoneNumber;
            aStaff.hourlyWage = Convert.ToDouble(HourlyWage);
            aStaff.hoursWorked = Convert.ToDouble(Hoursworked);
            aStaff.dateStarted = cldrDateJoined.SelectedDate;
            aStaff.availableToWork = chckAvailableToWork.Checked;
            //Create a new instance of adress collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //If this is a new record then add the data
            if(StaffId == -1)
            {
                //Set ThisStaff property
                StaffList.ThisStaff = aStaff;
                //Add the new record
                StaffList.Add();
            } else
            {
                //Find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //Set the ThisStaff property
                StaffList.ThisStaff = aStaff;
                //Update the record
                StaffList.Update();
            }
            //Redirect to the list page
            Response.Redirect("StaffList.aspx");
        } else
        {
            //Display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        Int32 staffNo;
        Boolean found = false;
        staffNo = Convert.ToInt32(txtStaffId.Text);
        found = aStaff.Find(staffNo);
        if (found == true)
        {
            txtHourlyWage.Text = aStaff.hourlyWage.ToString();
            txtHoursWorked.Text = aStaff.hoursWorked.ToString();
            txtStaffName.Text = aStaff.name;
            txtStaffPhoneNumber.Text = aStaff.phoneNumber;
            chckAvailableToWork.Checked = aStaff.availableToWork;
            lblDate.Text = "Date Joined: " + aStaff.dateStarted.ToString();
        } else
        {
            lblError.Text = "ERROR- DATA NOT FOUND!";
        }
    }
}