using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //Capture the full name
        aStaff.name = txtStaffName.Text;
        aStaff.phoneNumber = txtStaffPhoneNumber.Text;
        aStaff.hourlyWage = Convert.ToDouble(txtHourlyWage.Text);
        aStaff.hoursWorked = Convert.ToDouble(txtHoursWorked.Text);
        aStaff.dateStarted = cldrDateJoined.SelectedDate;
        aStaff.availableToWork = chckAvailableToWork.Checked;
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
            txtHourlyWage.Text = aStaff.hourlyWage.ToString();
            txtHoursWorked.Text = aStaff.hoursWorked.ToString();
            txtStaffName.Text = aStaff.name;
            txtStaffPhoneNumber.Text = aStaff.phoneNumber;
            chckAvailableToWork.Checked = aStaff.availableToWork;
            cldrDateJoined.SelectedDate = aStaff.dateStarted;
        } else
        {
            lblError.Text = "ERROR- DATA NOT FOUND!";
        }
    }
}