using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        aStaff.Name = txtStaffName.Text;
        aStaff.PhoneNumber = txtStaffPhoneNumber.Text;
        aStaff.HourlyWage = Convert.ToDouble(txtHourlyWage.Text);
        aStaff.HoursWorked = Convert.ToDouble(txtHoursWorked.Text);
        aStaff.DateStarted = cldrDateJoined.SelectedDate;
        aStaff.AvailableToWork = chckAvailableToWork.Checked;
        //Store the name in the session object
        Session["aStaff"] = aStaff;
        //Navigate to the the viewer page
        Response.Redirect("StaffViewer.aspx");
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
            txtHourlyWage.Text = aStaff.HourlyWage.ToString();
            txtHoursWorked.Text = aStaff.HoursWorked.ToString();
            txtStaffName.Text = aStaff.Name;
            txtStaffPhoneNumber.Text = aStaff.PhoneNumber;
            chckAvailableToWork.Checked = aStaff.AvailableToWork;
            cldrDateJoined.SelectedDate = aStaff.DateStarted;
        } else
        {
            lblError.Text = "ERROR- DATA NOT FOUND!";
        }
    }
}