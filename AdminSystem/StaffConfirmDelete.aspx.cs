using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //Var to store the primary key value of the record to be deleted
    Int32 StaffId;
  //Event handler for the load event
  protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of the record to be deleted from the session object
        StaffId = Convert.ToInt32(Session["StaffId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Create a new instance of the staff collection class
        clsStaffCollection StaffBook = new clsStaffCollection();
        //Find the record to delete
        StaffBook.ThisStaff.Find(StaffId);
        //Delete the record
        StaffBook.Delete();
        //Redirect to the main page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirect to the main page
        Response.Redirect("StaffList.aspx");
    }
}