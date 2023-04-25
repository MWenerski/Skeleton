using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //Update the list box
            DisplayStaff();
        }

    }

    void DisplayStaff()
    {
        //Create an instance of the Staff Collection
        clsStaffCollection Staff = new clsStaffCollection();
        //Set the data source to list of staff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //Set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //Set the data field to display
        lstStaffList.DataTextField = "Name";
        //Bind the data to this list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //Redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Var to store the primary key of the value to be edited
        Int32 StaffId;
        //If a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //Store the data in the session object
            Session["StaffId"] = StaffId;
            //Redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        } else 
        {
            lblError.Text = "Please select a record to edit from this list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Var to store the primary key value of the record to be deleted
        Int32 StaffId;
        //If a record has been selected from this list
        if(lstStaffList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to delete
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //Store the data in the session object
            Session["StaffId"] = StaffId;
            //Redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        } else
        {
            lblError.Text = "Please select a record to delete from this list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //Create an instance of the staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportsByName(txtFilterName.Text);
        lstStaffList.DataSource = Staff.StaffList;
        //Set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //Set the name of the field to display
        lstStaffList.DataTextField = "name";
        //Bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //Create an instance of the staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportsByName("");
        //Clear an existing filter to tidy up the interface
        txtFilterName.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        //Set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //Set the name of the field to display
        lstStaffList.DataTextField = "StaffName";
        //Bind the data to the list
        lstStaffList.DataBind();
    }
}